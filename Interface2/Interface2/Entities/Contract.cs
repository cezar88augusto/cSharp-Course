using System;
using System.Collections.Generic;
using System.Text;

namespace Interface2.Entities
{
    class Contract
    {
        public int Number { get; set; }
        public DateTime Date { get; set; }
        public Double TotalValue { get; set; }

        public Installment installment;

        public Contract(int number, DateTime date, double totalValue)
        {
            Number = number;
            Date = date;
            TotalValue = totalValue;
            installment = null;
        }
    }
}
