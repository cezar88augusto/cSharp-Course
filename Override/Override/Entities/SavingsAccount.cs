namespace Course.Entities
{
    class SavingsAccount : Account // HERDANDO AS FUNCIONALIDADE DA CLASSE ACCOUNT.
    {
        public double InterestRate { get; set; }

        public SavingsAccount()
        {
        }

        public SavingsAccount(int number, string holder, double balance, double interestRate)
            : base(number, holder, balance)
        {
            InterestRate = interestRate;
        }

        public void UpdateBalance()
        {
            Balance += Balance * InterestRate;
        }

        public override void Withdraw(double amount)// SOBRE ESCREVENDO UM MÉTODO DA SUPERCLASSE (ACCOUNT)
        {
            Balance -= amount;

            //pode ser assim tb:
            //chamando a implementação da superclasse com a palavra BASE:
            //base.Withdraw(amount);
            //Balance -= 2;
        }
    }
}
