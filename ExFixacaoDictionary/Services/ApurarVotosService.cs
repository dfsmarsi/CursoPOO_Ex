using ExFixacaoDictionary.Entidades;
using System.IO;

namespace ExFixacaoDictionary.Services
{
    class ApurarVotosService
    {
        private ICalcularVotosService _calcularVotosService;

        public ApurarVotosService(ICalcularVotosService calcularVotosService)
        {
            _calcularVotosService = calcularVotosService;
        }

        public void ApurarVotos(Candidato candidato)
        {
            _calcularVotosService.CalcularVotos(candidato);
        }
    }
}
