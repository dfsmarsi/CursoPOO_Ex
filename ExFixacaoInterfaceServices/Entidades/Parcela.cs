using System;

namespace ExFixacaoInterfaceServices.Entidades
{
    class Parcela
    {
        public DateTime Data { get; set; }
        public double Valor { get; set; }

        public Parcela(DateTime data, double valor)
        {
            Data = data;
            Valor = valor;
        }

        public override string ToString()
        {
            return $"{Data.ToString("d")} - {Valor.ToString("F2")}";
        }
    }
}
