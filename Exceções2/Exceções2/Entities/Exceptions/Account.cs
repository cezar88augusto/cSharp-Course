using System;
using System.Collections.Generic;
using System.Text;

namespace Exceções2.Entities.Exceptions
{
    class Account
    {
        public int Number { get; set; }
        public String Holder { get; set; }
        public double Balance { get; set; }
        public double WithdrawLimit { get; set; }

        public Account(int number, string holder, double balance, double withdrawLimit)
        {
            Number = number;
            Holder = holder;
            Balance = balance;
            WithdrawLimit = withdrawLimit;
        }

        public void Deposit (Double amount)
        {
            Balance = Balance + amount;
        }

        public void Withdraw (Double amount)
        {
            if (amount > Balance)
            {
                throw new DomainException("Not enough balance. ");
            }
            else if (amount > WithdrawLimit)
            {
                throw new DomainException("Amount exceeds withdraw limit. ");
            }

            Balance = Balance - amount;
        }

        public override string ToString()
        {
            return "Acc Number: "
                + Number
                + "Holder: "
                + Holder
                + "Acc Balance: "
                + Balance
                + " Acc Limit: "
                + WithdrawLimit;
        }


    }
}
