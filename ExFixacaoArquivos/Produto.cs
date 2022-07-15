using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExFixacaoArquivos
{
    class Produto
    {
        public string Nome { get; set; }
        public double Valor { get; set; }
        public int Quantidade { get; set; }

        public Produto(string nome, double valor, int quantidade)
        {
            Nome = nome;
            Valor = valor;
            Quantidade = quantidade;
        }

        public double CalcularValorTotal()
        {
            return Valor * Quantidade;
        }

        public override string ToString()
        {
            return $"{Nome} Valor Total: {CalcularValorTotal()}";
        }
    }
}
