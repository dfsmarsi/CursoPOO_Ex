using System;
using System.Collections.Generic;

namespace ExFixacaoHashset
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<Curso> colecao = new HashSet<Curso>();
            Console.Write("Quantidade alunos curso A: ");
            int qtde = int.Parse(Console.ReadLine());
            LerAlunosDosCursos(qtde, colecao);
            Console.Write("Quantidade alunos curso B: ");
            qtde = int.Parse(Console.ReadLine());
            LerAlunosDosCursos(qtde, colecao);
            Console.Write("Quantidade alunos curso C: ");
            qtde = int.Parse(Console.ReadLine());
            LerAlunosDosCursos(qtde, colecao);

            Console.WriteLine("Total de alunos: " + colecao.Count);

        }

        private static void LerAlunosDosCursos(int qtdeAlunos, HashSet<Curso> colecao)
        {
            for (int i = 1; i <= qtdeAlunos; i++)
            {
                int id = int.Parse(Console.ReadLine());
                colecao.Add(new Curso { IdAluno = id });
            }
        }
    }
}
