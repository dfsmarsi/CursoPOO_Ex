using ExFixacaoLinq.Entidades;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExFixacaoLinq.Services
{
    class LerDadosDeArquivoService

    {
        public void Txt(string caminho, List<Funcionario> listFuncionario)
        {
            using (StreamReader sr = File.OpenText(caminho))
            {
                PercorrerLinhasDoArquivoTxt(listFuncionario, sr);
            }
        }

        private static void PercorrerLinhasDoArquivoTxt(List<Funcionario> listFuncionario, StreamReader sr)
        {
            while (!sr.EndOfStream)
            {
                string[] linha = sr.ReadLine().Split(",");
                string nome = linha[0];
                string email = linha[1];
                double salario = double.Parse(linha[2], CultureInfo.InvariantCulture);
                listFuncionario.Add(new Funcionario(nome, email, salario));
            }
        }
    }
}
