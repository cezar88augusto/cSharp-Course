using System;
using System.Collections.Generic;
using System.Text;

namespace Interface2.Services
{
    class PayPalService : IOnlineContractService
    {
        public double paymentFee(double amount)
        {
            return amount * 0.1;
        }

        public double interest(double amount, int months)
        {
            for (int i = 0; i < months; i++)
            {
                amount *= 0.01;
                amount = amount + (amount * 0.02);
               
            }
            return amount;

        }

    }
}
