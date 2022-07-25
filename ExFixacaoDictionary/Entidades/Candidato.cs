using ExFixacaoDictionary.Services;
using System.Collections.Generic;

namespace ExFixacaoDictionary.Entidades
{
    class Candidato
    {
        public string Nome { get; set; }
        public int QuantidadeVotos { get; set; }

        public Candidato()
        {
        }

        public Candidato(string nome, int quantidadeVotos)
        {
            Nome = nome;
            QuantidadeVotos = quantidadeVotos;
        }
    }
}
