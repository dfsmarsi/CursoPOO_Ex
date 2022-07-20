using System;

namespace ExFixacaoInterface.Excecoes
{
    class DomainException : ApplicationException
    {
        public DomainException(string message) : base(message){}
    }
}
