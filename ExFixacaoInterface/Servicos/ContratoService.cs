using ExFixacaoInterface.Entidades;
using System;

namespace ExFixacaoInterface.Servicos
{
    class ContratoService
    {
        private IPagamentoOnlineService _pagamentoOnlineService;

        public ContratoService(IPagamentoOnlineService pagamentoOnlineService)
        {
            _pagamentoOnlineService = pagamentoOnlineService;
        }

        public void ProcessarContrato(Contrato contrato, int meses)
        {
            double valorBase = contrato.ValorTotal / meses;
            for (int i = 1; i <= meses; i++)
            {
                DateTime data = contrato.Data.AddMonths(i);
                double valorComJuros = valorBase + _pagamentoOnlineService.ValorJurosMensal(valorBase, i);
                double valorFinal = valorComJuros + _pagamentoOnlineService.ValorTaxaPagamento(valorComJuros);
                contrato.AddParcela(new Parcela(data, valorFinal));
            }
        }
    }
}
