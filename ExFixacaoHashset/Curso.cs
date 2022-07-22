
using System;
using System.Collections.Generic;

namespace ExFixacaoHashset
{
    class Curso
    {
        public int IdAluno { get; set; }

        public override int GetHashCode()
        {
            return IdAluno.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            if (!(obj is Curso))
                return false;
            Curso outro = obj as Curso;
            return IdAluno.Equals(outro.IdAluno);
        }
    }
}
