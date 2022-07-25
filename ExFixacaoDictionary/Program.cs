using ExFixacaoDictionary.Entidades;
using ExFixacaoDictionary.Services;
using System;
using System.Collections.Generic;

namespace ExFixacaoDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> dicionarioCandidatos = new Dictionary<string, int>();
            string caminho = @"";

            Candidato candidato = new Candidato();
            ApurarVotosService apurarVotos = new ApurarVotosService(new CalculoVotosPorArquivoService(caminho, dicionarioCandidatos));
            apurarVotos.ApurarVotos(candidato);
        }
    }
}
