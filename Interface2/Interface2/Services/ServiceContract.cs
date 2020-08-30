using Interface2.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Interface2.Services
{
    class ServiceContract
    {
        public int Months { get; set; }

        private Contract contract;

        public ServiceContract(int months, Contract contract)
        {
            Months = months;
            this.contract = contract;
        }
    }
}
