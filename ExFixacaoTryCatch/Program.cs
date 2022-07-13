using ExFixacaoTryCatch.Entidades;
using ExFixacaoTryCatch.Entidades.Excecoes;
using System;

namespace ExFixacaoTryCatch
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Digite os dados da conta: ");
                Console.Write("Número: ");
                int numeroConta = int.Parse(Console.ReadLine());
                Console.Write("Nome do Titular da conta: ");
                string nomeTitular = Console.ReadLine();
                Console.Write("Saldo inicial: ");
                double saldoInicial = double.Parse(Console.ReadLine());
                Console.Write("Limite de saque: ");
                double limiteSaque = double.Parse(Console.ReadLine());
                Conta conta = new Conta(numeroConta, nomeTitular, saldoInicial, limiteSaque);
                Console.WriteLine();
                Console.WriteLine("Informe o valor do saque: ");
                double valorSaque = double.Parse(Console.ReadLine());
                conta.Saque(valorSaque);
                Console.WriteLine(conta.ToString());

            }
            catch (FormatException e)
            {
                Console.WriteLine("Formato do valor incorreto!" + e.Message);
            }
            catch (DomainException e)
            {
                Console.WriteLine("Erro na Conta: " + e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine("Erro inesperado : " + e.Message);
            } 
        }
    }
}
