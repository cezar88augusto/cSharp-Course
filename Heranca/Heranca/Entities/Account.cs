

namespace Heranca.Entities
{
    class Account
    {
        public int Number { get; private set; } // Manter o acesso privado: private

        public string Holder { get; private set; } // Manter o acesso privado: private

        public double Balance { get; protected set; } // Protected = pode ser acessado em sub classe!

        public Account()

        {

        }


        public Account(int number, string holder, double balance)

        {
            Number = number;
            Holder = holder;
            Balance = balance;
        }


        public void Withdraw(double amount)

        {
            Balance -= amount;
        }


        public void Deposit(double amount)

        {
            Balance += amount;
        }
    }
}
