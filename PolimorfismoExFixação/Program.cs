using PolimorfismoExFixação.Entidades;
using System;
using System.Collections.Generic;

namespace PolimorfismoExFixação
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Produto> listProduto = new List<Produto>();
            Console.WriteLine("Quantidade de produtos: ");
            int qtdProd = int.Parse(Console.ReadLine());
            for (int i = 1; i <= qtdProd; i++)
            {
                Console.WriteLine($"Produto #{i}");
                Console.Write("Informe o tipo do produto (c / u / i): ");
                char tipoProduto = char.Parse(Console.ReadLine());
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("Preco: ");
                double preco = double.Parse(Console.ReadLine());
                if (tipoProduto == 'i')
                {
                    Console.Write("Valor Adicional: ");
                    double custoAdicional = double.Parse(Console.ReadLine());
                    listProduto.Add(new ProdutoImportado(nome, preco, custoAdicional));
                }
                else if (tipoProduto == 'u')
                {
                    Console.Write("Data Fabricação: ");
                    DateTime dataFabricacao = DateTime.Parse(Console.ReadLine());
                    listProduto.Add(new ProdutoUsado(nome, preco, dataFabricacao));
                }
                else
                    listProduto.Add(new Produto(nome, preco));
            }
            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine("Etiquetas dos Produtos:");
            foreach (Produto produto in listProduto)
                Console.WriteLine($"{produto.Etiqueta()}");
        }
    }
}
