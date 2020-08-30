using Polimorfismo.Entities;
using System;
using System.Collections.Generic;

namespace Polimorfismo
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Enter the number of products: ");
            int number = int.Parse(Console.ReadLine());

            List<Product> list = new List<Product>();


            for (int i = 0; i < number; i++)
            {
                Console.WriteLine("Common, used or imported (c/u/i)? ");
                char x = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Price: ");
                double price = double.Parse(Console.ReadLine());

                if (x == 'i')
                {
                    Console.Write("Customs fee: ");
                    double fee = double.Parse(Console.ReadLine());
                    list.Add(new ImportedProduct(name, price, fee));

                }
                else if (x == 'u')
                {
                    Console.Write("Manufacture date (DD/MM/YYYY): ");
                    DateTime data = DateTime.Parse(Console.ReadLine());
                    list.Add(new UsedProduct(name, price, data));
                }
                else
                {
                    list.Add(new Product(name, price));
                }
            }

            foreach (Product prod in list)
            {
                Console.WriteLine(prod.priceTag());

            }


            Console.ReadKey();
         
        }
    }
}
