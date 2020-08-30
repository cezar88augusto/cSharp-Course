using System;
using System.Collections.Generic;
using System.Text;

namespace Interface2.Entities
{
    class Installment
    {
        public DateTime DueDate { get; set; }
        public Double MyProperty { get; set; }

        public Installment(DateTime dueDate, double myProperty)
        {
            DueDate = dueDate;
            MyProperty = myProperty;
        }
    }
}
