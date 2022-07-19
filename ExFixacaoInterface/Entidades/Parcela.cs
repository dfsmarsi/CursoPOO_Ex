using System;

namespace ExFixacaoInterface.Entidades
{
    class Parcela
    {
        public DateTime DataVencimento { get; set; }
        public double ValorParcela { get; set; }

        public Parcela(DateTime dataVencimento, double valorParcela)
        {
            DataVencimento = dataVencimento;
            ValorParcela = valorParcela;
        }

        public override string ToString()
        {
            return DataVencimento.ToString("dd/MM/yy") + " - " + ValorParcela.ToString("F2");
        }
    }
}
