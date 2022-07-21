using ExFixacaoInterfaceServices.Entidades;
using ExFixacaoInterfaceServices.Services;
using System;

namespace ExFixacaoInterfaceServices
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Dados do contrato: ");
            Console.Write("Numero: ");
            int numero = int.Parse(Console.ReadLine());
            Console.Write("Data: ");
            DateTime data = DateTime.Parse(Console.ReadLine());
            Console.Write("Valor: ");
            double valor = double.Parse(Console.ReadLine());
            Console.Write("Quantidade de parcelas: ");
            int meses = int.Parse(Console.ReadLine());

            Contrato contrato = new Contrato(numero, data, valor);
            ContratoService contratoService = new ContratoService(new PaypalService());
            contratoService.ProcessarContrato(contrato, meses);

            Console.WriteLine("Parcelas: ");
            foreach (var parcela in contrato.ListaParcelas)
                Console.WriteLine(parcela);
        }
    }
}
