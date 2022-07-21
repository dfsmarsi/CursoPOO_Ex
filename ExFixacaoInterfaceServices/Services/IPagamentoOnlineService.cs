namespace ExFixacaoInterfaceServices.Services
{
    interface IPagamentoOnlineService
    {
        double CalcularTaxaDePagamento(double valor);
        double CalcularJurosMensal(double valor, int meses);
    }
}
