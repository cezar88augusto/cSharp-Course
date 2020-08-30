using AssociacaoProjeto.Entities;
using AssociacaoProjeto.Entities.Enums;
using System;
using System.Globalization;

namespace AssociacaoProjeto
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter department's name: ");

            string deptName = Console.ReadLine();

            Console.WriteLine("Enter worker data:");

            Console.Write("Name: ");

            string name = Console.ReadLine();

            Console.Write("Level: (Junior/MidLevel/Senior): ");

            WorkerLevel level = Enum.Parse<WorkerLevel>(Console.ReadLine());

            Console.Write("Base salary: ");

            double baseSalary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("How many contracts to this worker? ");

            int n = int.Parse(Console.ReadLine());

            Department department = new Department(deptName);
            Worker worker = new Worker(name, level, baseSalary, department);



            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Enter #{i} contract data:");

                Console.Write("Date (DD/MM/YYYY): ");

                DateTime date = DateTime.Parse(Console.ReadLine());

                Console.Write("Value per hour: ");

                double valuePerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Console.Write("Duration (hours): ");

                int hours = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter #{0} contract data: " + i + 1);

                HourContract contract = new HourContract(date, valuePerHour, hours);

                worker.AddContract(contract);

            }
            Console.WriteLine();
            Console.Write("Enter month and year to calculate income (MM/YYYY): ");

            string monthAndYear = Console.ReadLine();

            int month = int.Parse(monthAndYear.Substring(0, 2));

            int year = int.Parse(monthAndYear.Substring(3));

            Console.WriteLine("Name : " + worker.name);

            Console.WriteLine("Department: " + worker.Department.name);

            Console.WriteLine("Income for " + monthAndYear + ": " + worker.Income(year, month).ToString("F2", CultureInfo.InvariantCulture));






        }
    }
}
