using Course.Entities;
using System;

namespace Override
{
    class Program
    {
        static void Main(string[] args)
        {

            Account acc1 = new Account(1000, "Alex", 500.0);
            Account acc2 = new SavingsAccount(1000,"Maria", 500.0,0);

            //Se não houver um método OVERRIDE, será debitado uma TAXA tanto na conta poupança quanto na conta normal.
            acc1.Withdraw(10);
            acc2.Withdraw(10);

            Console.WriteLine(acc1.Balance);
            Console.WriteLine(acc2.Balance);

        }
    }
}
