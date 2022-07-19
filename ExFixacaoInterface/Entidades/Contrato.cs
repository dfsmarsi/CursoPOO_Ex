using System;
using System.Collections.Generic;

namespace ExFixacaoInterface.Entidades
{
    class Contrato
    {
        public int Numero { get; set; }
        public DateTime Data { get; set; }
        public double ValorTotal { get; set; }
        public List<Parcela> ListaParcelas { get; set; }

        public Contrato(int numero, DateTime data, double valorTotal)
        {
            Numero = numero;
            Data = data;
            ValorTotal = valorTotal;
            ListaParcelas = new List<Parcela>();
        }

        public void AddParcela(Parcela parcela)
        {
            ListaParcelas.Add(parcela);
        }
    }
}
