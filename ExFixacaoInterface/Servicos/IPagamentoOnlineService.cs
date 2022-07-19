namespace ExFixacaoInterface.Servicos
{
    interface IPagamentoOnlineService
    {
        double ValorTaxaPagamento(double valorTaxa);
        double ValorJurosMensal(double valor, int meses);
    }
}
