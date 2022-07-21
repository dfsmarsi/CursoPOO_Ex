namespace ExFixacaoInterfaceServices.Services
{
    class PaypalService : IPagamentoOnlineService
    {
        private double _TaxaDePagamento = 0.02;
        private double _JurosMensal = 0.01;

        public double CalcularTaxaDePagamento(double valor)
        {
            return valor * _TaxaDePagamento;
        }

        public double CalcularJurosMensal(double valor, int meses)
        {
            return valor * (meses * _JurosMensal);
        }
    }
}
