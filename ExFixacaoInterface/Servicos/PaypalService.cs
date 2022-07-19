namespace ExFixacaoInterface.Servicos
{
    class PaypalService : IPagamentoOnlineService
    {
        private const double TaxaDePagamento = 0.02;
        private const double JurosMensal = 0.01;

        public double ValorJurosMensal(double valor, int meses)
        {
            return valor * JurosMensal * meses;
        }

        public double ValorTaxaPagamento(double valor)
        {
            return valor * TaxaDePagamento;
        }
    }
}
