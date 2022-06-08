using ExComposicao1.Entities.Enums;
using System;
using System.Collections.Generic;

namespace ExComposicao1.Entities
{
    public class Worker
    {
        public String Name { get; set; }
        public WorkerLevel Level { get; set; }
        public double BaseSalary { get; set; }
        public Department Department { get; set; }
        public List<HourContract> ListContracts { get; set; } = new List<HourContract>();

        public Worker(string nameWork, WorkerLevel level, double baseSalary, string nameDepartment)
        {
            Name = nameWork;
            Level = level;
            BaseSalary = baseSalary;
            Department = new Department(nameDepartment);
        }

        public void AddContract(HourContract contract) => ListContracts.Add(contract);

        public void RemoveContract(HourContract contract) => ListContracts.Add(contract);

        public double Income(int year, int month)
        {
            double sum = BaseSalary;

            foreach (HourContract contract in ListContracts)
            {
                if (contract.Date.Year == year && contract.Date.Month == month)
                    sum += contract.totalValue();
            }

            return sum;
        }
    }
}
