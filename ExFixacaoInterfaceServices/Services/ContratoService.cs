using ExFixacaoInterfaceServices.Entidades;
using System;

namespace ExFixacaoInterfaceServices.Services
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
            double valorBase = contrato.Valor/meses;
            for (int i = 1; i <= meses; i++)
            {
                DateTime dataParcela = contrato.Data.AddMonths(i);
                double valorComTaxaPagamento = valorBase + _pagamentoOnlineService.CalcularTaxaDePagamento(valorBase);
                double valorParcelaFinal = valorComTaxaPagamento + _pagamentoOnlineService.CalcularJurosMensal(valorComTaxaPagamento, i);
                contrato.AdicionarParcelas(new Parcela(dataParcela, valorParcelaFinal));
            }
        }
    }
}
