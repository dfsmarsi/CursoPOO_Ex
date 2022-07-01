using PolimorfismoEx1.Entidades;
using System;
using System.Collections.Generic;

namespace PolimorfismoEx1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Funcionario> listFuncionario = new List<Funcionario>();
            Console.WriteLine("Informe o numero de funcionários: ");
            int numFuncs = int.Parse(Console.ReadLine());
            for (int i = 1; i <= numFuncs; i++)
            {
                Console.WriteLine($"Funcionario #{i}");
                Console.Write("Funcionário é terceirizado? (S ou N) ");
                char opTerceirizado = char.Parse(Console.ReadLine());
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("Quantidade de horas: ");
                int quantidadeDeHoras = int.Parse(Console.ReadLine());
                Console.Write("Valor da hora: ");
                double valorHora = double.Parse(Console.ReadLine());
                if (opTerceirizado == 'S')
                {
                    Console.Write("Valor da despesa adicional: ");
                    double valorDespesaAdicional = double.Parse(Console.ReadLine());
                    listFuncionario.Add(new FuncionarioTerceirizado(nome, quantidadeDeHoras, valorHora, valorDespesaAdicional));
                }
                else
                    listFuncionario.Add(new Funcionario(nome, quantidadeDeHoras, valorHora));
            }
            Console.WriteLine("--------------------------------");
            Console.WriteLine("Pagamentos:");
            foreach (Funcionario funcionario in listFuncionario)
                Console.WriteLine($"{funcionario.Nome} : R${funcionario.Pagamento().ToString("F2")}");
        }
    }
}
