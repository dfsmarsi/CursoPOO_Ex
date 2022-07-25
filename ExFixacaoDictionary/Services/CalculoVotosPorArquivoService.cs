using ExFixacaoDictionary.Entidades;
using System.Collections.Generic;
using System.IO;

namespace ExFixacaoDictionary.Services
{
    class CalculoVotosPorArquivoService : ICalcularVotosService
    {
        public string CaminhoArquivo { get; set; }
        public Dictionary<string, int> DictionaryCandidatos { get; set; }

        public CalculoVotosPorArquivoService(string caminhoArquivo, Dictionary<string, int> dictionaryCandidatos)
        {
            CaminhoArquivo = caminhoArquivo;
            DictionaryCandidatos = dictionaryCandidatos;
        }

        public void CalcularVotos(Candidato candidato)
        {
            using (StreamReader sr = File.OpenText(CaminhoArquivo))
            {
                while(!sr.EndOfStream)
                {
                    string[] linhaVoto = sr.ReadLine().Split(',');
                    candidato.Nome = linhaVoto[0];
                    candidato.QuantidadeVotos = int.Parse(linhaVoto[1]);
                    PreencherDicionario(candidato);
                }
            }
        }
        
        private void PreencherDicionario(Candidato candidato)
        {
            if (DictionaryCandidatos.ContainsKey(candidato.Nome))
                DictionaryCandidatos[candidato.Nome] += candidato.QuantidadeVotos;
            else
                DictionaryCandidatos[candidato.Nome] = candidato.QuantidadeVotos;
        }
    }
}
