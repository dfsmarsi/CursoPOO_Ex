using ExFixacaoInterface.Entidades;
using ExFixacaoInterface.Excecoes;
using ExFixacaoInterface.Servicos;
using System;

namespace ExFixacaoInterface
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Informe os dados do contrato");
                Console.Write("Numero: ");
                int numeroContrato = int.Parse(Console.ReadLine());
                Console.Write("Data do contrato: ");
                DateTime dataContrato = DateTime.Parse(Console.ReadLine());
                Console.Write("Valor do contrato: ");
                double valorContrato = double.Parse(Console.ReadLine());
                Console.Write("Numero de parcelas: ");
                int numeroParcelas = int.Parse(Console.ReadLine());

                Contrato contrato = new Contrato(numeroContrato, dataContrato, valorContrato);

                ContratoService contratoService = new ContratoService(new PaypalService());

                contratoService.ProcessarContrato(contrato, numeroParcelas);

                foreach (var parcela in contrato.ListaParcelas)
                {
                    Console.WriteLine(parcela.ToString());
                }
            }
            catch (DomainException e)
            {
                Console.WriteLine("Erro na aplicação : " + e.Message);
            }
            catch (FormatException e)
            {
                Console.WriteLine("Erro de formatação: " + e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine("Erro generico: " + e.Message);
            }
        }
    }
}
