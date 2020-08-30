using AssociacaoProjeto3.Entities;
using System;

namespace AssociacaoProjeto3
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter cliente data: ");
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Email: ");
            string email = Console.ReadLine();
            Console.Write("Birth Date: ");
            DateTime birthDate = DateTime.Parse(Console.ReadLine());

            Client client = new Client(name, email, birthDate);

            Console.WriteLine("Enter order data: ");
            Console.Write("Status: ");
            OrderStatus status = Enum.Parse<OrderStatus>(Console.ReadLine());
            
            Console.Write("How many items to this order? ");
            int itemsNumber = int.Parse(Console.ReadLine());

            Order order = new Order(DateTime.Now, status, client);

            for (int i = 0; i < itemsNumber; i++)
            {
                Console.WriteLine();
                Console.WriteLine("Enter #{0} item data: ", i+1);
                Console.Write("Product name: ");
                string productName = Console.ReadLine();
                Console.Write("Product price: ");
                int productPrice = int.Parse(Console.ReadLine());
                Console.Write("Quantity: ");
                int productQuantity = int.Parse(Console.ReadLine());

                Product product = new Product(productName, productPrice);
                OrderItem orderItem = new OrderItem(productQuantity, productPrice, product);

                order.addItem(orderItem);
                Console.WriteLine();

            }

            Console.WriteLine(order);

            Console.ReadKey();

        }
    }
}
