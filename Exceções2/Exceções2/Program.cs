using Exceções2.Entities.Exceptions;
using System;

namespace Exceções2
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter account data: ");
            Console.Write("Number: ");
            int accNumber = int.Parse(Console.ReadLine());
            Console.Write("Holder: ");
            string accHolder = Console.ReadLine();
            Console.Write("Initial balance: ");
            double initBalance = double.Parse(Console.ReadLine());
            Console.Write("Withdraw limit: ");
            double limitWit = double.Parse(Console.ReadLine());
            Console.WriteLine();

            Account acc = new Account(accNumber, accHolder, initBalance, limitWit);

            Console.Write("Enter amount for withdraw: : ");
            double amountWit = double.Parse(Console.ReadLine());

            try
            {
                acc.Withdraw(amountWit);
                Console.WriteLine("New balance: " + acc.Balance);
            }
            catch (DomainException e)
            {
                Console.WriteLine("Error! " + e.Message);
            }

            Console.ReadKey();

        }
    }
}
