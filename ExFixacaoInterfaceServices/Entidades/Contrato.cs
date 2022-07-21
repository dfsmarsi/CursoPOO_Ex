using System;
using System.Collections.Generic;

namespace ExFixacaoInterfaceServices.Entidades
{
    class Contrato
    {
        public int Numero { get; set; }
        public DateTime Data { get; set; }
        public double Valor { get; set; }
        public List<Parcela> ListaParcelas;

        public Contrato(int numero, DateTime data, double valor)
        {
            Numero = numero;
            Data = data;
            Valor = valor;
            ListaParcelas = new List<Parcela>();
        }

        public void AdicionarParcelas(Parcela parcela)
        {
            ListaParcelas.Add(parcela);
        }
    }
}
