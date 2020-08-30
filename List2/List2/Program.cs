using System;
using System.Collections.Generic;
using System.Globalization;

namespace List2 {
    class Program {
        static void Main(string[] args) {

            Console.Write("How many employees will be registered? ");
            int number = int.Parse(Console.ReadLine());

            List<Employee> list = new List<Employee>();

            for (int i = 0; i < number; i++) {

                Console.WriteLine("Employee {0}", i + 1);
                Console.Write("Digite o {0} id: ", i + 1);
                int id = int.Parse(Console.ReadLine());
                Console.Write("Digite o {0} NOME: ", i + 1);
                string name = Console.ReadLine();
                Console.Write("Digite o {0} salário: ", i + 1);
                double salary = double.Parse(Console.ReadLine());

                list.Add(new Employee(id, name, salary));
            }

            Console.WriteLine("List Elements: ");

            foreach (var item in list) {

                Console.WriteLine(item);
            }

            Console.WriteLine();
            Console.Write("Enter the empolyee id that will have salary increase? ");
            int idToChangeSalary = int.Parse(Console.ReadLine());

            Employee emp = list.Find(x => x.id == idToChangeSalary);


            if (emp != null) {
                Console.Write("Enter the percentage: ");
                double percentage = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                emp.increaeSalary(percentage);
            }
            else {
                Console.WriteLine("This id does not exist!");
            }


            //OUTRA MANEIRA 

            /* Console.WriteLine();
            Console.Write("Enter the empolyee id that will have salary increase? ");
            int idToChangeSalary = int.Parse(Console.ReadLine());
                       
            foreach (var item in list) {
                if (item.id == idToChangeSalary) {
                    Console.Write("Enter the percentage: ");
                    int percentage = int.Parse(Console.ReadLine());
                    item.increaeSalary(percentage);
                }
                else {
                    Console.WriteLine("This id does not exist!");
                }
            }*/

            Console.WriteLine();
            Console.WriteLine("Updated List Elements: ");

            foreach (var item in list) {

                Console.WriteLine(item);
            }

            Console.ReadKey();

        }
    }
}
