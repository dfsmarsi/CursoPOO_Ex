using ExComposicao3.Entidades;
using ExComposicao3.Entidades.Enums;
using System;
using System.Globalization;

namespace ExComposicao3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter client data: ");
            Console.Write("Nome: ");
            string NomeCliente = Console.ReadLine();
            Console.Write("Email: ");
            string email = Console.ReadLine();
            Console.Write("Data de aniversario (DD/MM/YYYY): ");
            DateTime DataAniversario = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Informe os dados do pedido: ");
            Console.Write("Status: ");
            PedidoStatus status = Enum.Parse<PedidoStatus>(Console.ReadLine());

            Cliente cliente = new Cliente(NomeCliente, email, DataAniversario);
            Pedido pedido = new Pedido(DateTime.Now, status, cliente);

            Console.Write("Quantos itens tera o pedido? ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Enter #{i} item data:");
                Console.Write("Nome do Produto: ");
                string NomeProduto = Console.ReadLine();
                Console.Write("Preço do produto ");
                double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Produto produto = new Produto(NomeProduto, preco);

                Console.Write("Quantidade: ");
                int quantidade = int.Parse(Console.ReadLine());

                PedidoItem pedidoItem = new PedidoItem(quantidade, preco, produto);

                pedido.AddItem(pedidoItem);
            }

            Console.WriteLine();
            Console.WriteLine("Resumo do pedido:");
            Console.WriteLine(pedido.ToString());
        }
    }
}
