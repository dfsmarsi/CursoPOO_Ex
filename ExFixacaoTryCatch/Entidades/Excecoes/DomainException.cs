using System;

namespace ExFixacaoTryCatch.Entidades.Excecoes
{
    class DomainException : ApplicationException
    {
        public DomainException(string message) : base(message)
        {
        }
    }
}
