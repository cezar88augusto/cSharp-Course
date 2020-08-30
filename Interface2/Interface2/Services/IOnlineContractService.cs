using System;
using System.Collections.Generic;
using System.Text;

namespace Interface2.Services
{
    interface IOnlineContractService
    {
        double paymentFee(double amount);
        double interest(double amount, int months);
    }
}
