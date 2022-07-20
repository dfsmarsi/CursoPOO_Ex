using ExFixacaoInterface.Entidades;
using ExFixacaoInterface.Excecoes;
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
            if (contrato.ValorTotal == 0)
                throw new DomainException("Valor do contrato está zerado!");
            if (contrato.ValorTotal < 0)
                throw new DomainException("Valor do contrato não pode ser negativo!");
            if (meses < 1)
                throw new DomainException("A quantidade de parcelas tem que ser no minimo 1");

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
