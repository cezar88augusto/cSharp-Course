using MetodosAbstratos.Entities;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace MetodosAbstratos
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> list = new List<Person>();

            list.Add(new Company("Soft", 400000, 25));
            list.Add(new Individual("Cézar", 50000, 2000));

            double sum = 0;
            foreach (Person p in list)
            {
                Console.WriteLine(p.Name + " / R$ " + p.TaxesPaid().ToString("F2", CultureInfo.InvariantCulture));
                sum += p.TaxesPaid();
            }

            Console.WriteLine("Total de taxa paga por todos: " + sum);

            Console.ReadKey();
        }
    }
}
