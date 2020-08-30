using AssociacaoProjeto.Entities.Enums;
using System.Collections.Generic;


namespace AssociacaoProjeto.Entities
{
    class Worker
    {
        public string name { get; set; }
        public WorkerLevel level { get; set; }
        public double baseSalary { get; set; }
        public Department Department { get; set; }
        public List<HourContract> Contracts { get; set; } = new List<HourContract>();

        public Worker(string name, WorkerLevel level, double baseSalary, Department department)
        {
            this.name = name;
            this.level = level;
            this.baseSalary = baseSalary;
            Department = department;
        }

        public void AddContract(HourContract contract)
        {
            Contracts.Add(contract);
        }

        public void RemoveContract(HourContract contract)
        {
            Contracts.Remove(contract);
        }

        public double Income(int year, int month)
        {
            double sum = baseSalary;

            // Para cara HourContract na lista de Contracts
            foreach (HourContract contract in Contracts)
            {
                if (contract.Date.Year == year && contract.Date.Month == month)
                {
                    sum += (contract.Hours * contract.ValuePerHour);
                }
            }
            return sum;

        }
    }
}
