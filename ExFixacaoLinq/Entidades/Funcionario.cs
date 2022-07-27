using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExFixacaoLinq.Entidades
{
    class Funcionario
    {
        public string  Nome { get; set; }
        public string Email { get; set; }
        public double Salario { get; set; }

        public Funcionario()
        {
        }

        public Funcionario(string nome, string email, double salario)
        {
            Nome = nome;
            Email = email;
            Salario = salario;
        }

        public void MostrarEmailsEmOrdemAlfabeticaQuandoSalarioMaiorQueValorPassado(List<Funcionario> funcionario, double valor)
        {
            var resultado = funcionario.Where(f => f.Salario > valor).OrderBy(f => f.Email).Select(f => f.Email);
            foreach (var result in resultado)
                Console.WriteLine(result);
        }

        public void MostrarMediaSalariosFuncionariosComInicialM(List<Funcionario> funcionario)
        {
            var resultado = funcionario.Where(f => f.Nome[0] == 'M').Select(f => f.Salario).DefaultIfEmpty(0.0).Sum();
            Console.WriteLine("Media Salarios M: " + resultado.ToString("F2"));
        }
    }
}
