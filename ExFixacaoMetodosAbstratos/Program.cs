using ExFixacaoMetodosAbstratos.Entidades;
using System;
using System.Collections.Generic;

namespace ExFixacaoMetodosAbstratos
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Pessoa> listPessoas = new List<Pessoa>();
            Console.Write("Informe o numero de contribuintes: ");
            int qtdContribuintes = int.Parse(Console.ReadLine());
            for (int i = 1; i <= qtdContribuintes; i++)
            {
                Console.WriteLine($"Contribuinte #{i}");
                Console.Write("Informe o tipo de contribuinte: (PJ ou PF) ");
                string tipoContribuinte = Console.ReadLine();
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("Renda Anual: ");
                double rendaAnual = double.Parse(Console.ReadLine());
                if (tipoContribuinte == "PF" || tipoContribuinte == "pf")
                {
                    Console.Write("Valor gasto com Saude: ");
                    double valorGastoSaude = double.Parse(Console.ReadLine());
                    listPessoas.Add(new PessoaFisica(nome, rendaAnual, valorGastoSaude));
                }
                else
                {
                    Console.Write("Numero de Colaboradores: ");
                    int numColaboradores = int.Parse(Console.ReadLine());
                    listPessoas.Add(new PessoaJuridica(nome, rendaAnual, numColaboradores));
                }
            }
            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine("Impostos pagos:");
            double sum = 0.0;
            foreach (Pessoa pessoa in listPessoas)
            {
                Console.WriteLine($"{pessoa.Nome}: R$ {pessoa.CalcularImposto().ToString("F2")}");
                sum += pessoa.CalcularImposto();
            }
            Console.WriteLine("Total de impostos: " + sum.ToString("F2"));                
        }
    }
}
