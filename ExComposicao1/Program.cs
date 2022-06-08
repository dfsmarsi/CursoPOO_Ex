using ExComposicao1.Entities;
using ExComposicao1.Entities.Enums;
using System;

namespace ExComposicao1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Informe o seu departamento: ");
            string nomeDepartamento = Console.ReadLine();
            Console.Write("Informe os dados do funcionário: \nNome: ");
            string nomeFuncionario = Console.ReadLine();
            Console.Write("Nível (Junior/MidLevel/Senior): ");
            WorkerLevel nivelCompetencia = Enum.Parse<WorkerLevel>(Console.ReadLine());
            Console.Write("Salário base: ");
            double salarioBase = double.Parse(Console.ReadLine());
            Console.WriteLine("Informe a quantidade de contratos: ");
            int qtdeContratos = int.Parse(Console.ReadLine());

            Worker trabalho = new Worker(nomeFuncionario, nivelCompetencia, salarioBase, nomeDepartamento);

            for (int i = 1; i <= qtdeContratos; i++)
            {
                HourContract contrato = new HourContract();
                Console.WriteLine($"Contrato {i}:");
                Console.Write("Data (DD/MM/AAAA):");
                contrato.Date = DateTime.Parse(Console.ReadLine());
                Console.Write("Valor por hora: ");
                contrato.valuePerHour = double.Parse(Console.ReadLine());
                Console.Write("Duração de horas: ");
                contrato.Hours = int.Parse(Console.ReadLine());

                trabalho.AddContract(contrato);
            }

            Console.WriteLine("\n\n");
            Console.Write("Informe o mes e ano para calculo da renda: ");
            DateTime dataFiltro = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("------------------------------------------------------------");
            Console.WriteLine($"Nome: {trabalho.Name}\nDepartamento: {trabalho.Department.NameDepartment}\nRenda do mes: {trabalho.Income(dataFiltro.Year, dataFiltro.Month)}");
        }
    }
}
