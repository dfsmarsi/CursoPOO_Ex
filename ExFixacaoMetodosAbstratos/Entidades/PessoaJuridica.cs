using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExFixacaoMetodosAbstratos.Entidades
{
    class PessoaJuridica : Pessoa
    {
        public int NumeroColaboradores { get; set; }

        public PessoaJuridica(string nome, double rendaAnual ,int numeroColaboradores) 
            : base(nome, rendaAnual)
        {
            NumeroColaboradores = numeroColaboradores;
        }

        public override double CalcularImposto()
        {
            double valorImposto = 0.0;
            if (NumeroColaboradores <= 10)
                valorImposto = RendaAnual * 0.16;
            else
                valorImposto = RendaAnual * 0.14;
            
            return valorImposto;
        }
    }
}
