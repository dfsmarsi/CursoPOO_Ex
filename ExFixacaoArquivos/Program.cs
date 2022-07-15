using System.Collections.Generic;
using System.Globalization;
using System.IO;

namespace ExFixacaoArquivos
{
    class Program
    {
        static void Main(string[] args)
        {
            string caminhoOriginal = @"C:\Automacao\produtos.txt";
            string caminhoCopia = @"C:\Automacao\Pasta\ProdutosTotal.txt";
            try
            {
                string[] linhas = File.ReadAllLines(caminhoOriginal);
                Directory.CreateDirectory(@"C:\Automacao\Pasta");
                using (StreamWriter sw = File.AppendText(caminhoCopia))
                {
                    foreach (var linha in linhas)
                    {
                        string[] dados = linha.Split(',');
                        Produto produto = new Produto(dados[0], double.Parse(dados[1], CultureInfo.InvariantCulture), int.Parse(dados[2]));

                        sw.WriteLine($"{produto.Nome}, {produto.CalcularValorTotal().ToString("F2")}");
                    }
                }
            }
            catch (IOException e)
            {
                System.Console.WriteLine("Erro ocorrido: " + e.Message);
            }
        }
    }
}
