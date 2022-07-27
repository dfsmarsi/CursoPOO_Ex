using ExFixacaoLinq.Entidades;
using ExFixacaoLinq.Services;
using System;
using System.Collections.Generic;

namespace ExFixacaoLinq
{
    class Program
    {
        static void Main(string[] args)
        {
            string caminho = @"C:\Sistemasbr\Funcionarios.txt";

            Funcionario funcionario = new Funcionario();
            List<Funcionario> listFuncionario = new List<Funcionario>();
            LerDadosDeArquivoService lerDados = new LerDadosDeArquivoService();

            lerDados.Txt(caminho, listFuncionario);

            funcionario.MostrarEmailsEmOrdemAlfabeticaQuandoSalarioMaiorQueValorPassado(listFuncionario, 2000);

            funcionario.MostrarMediaSalariosFuncionariosComInicialM(listFuncionario);

        }
    }
}
