using System;
using System.Collections.Generic;
using System.Text;

namespace MetodosAbstratos.Entities
{
    class Company : Person
    {
        public int NumberOfEmployee { get; set; }

        public Company()
        {
        }

        public Company(string name, double anualIncomes, int numberOfEmployee) : base (name, anualIncomes)
        {
            NumberOfEmployee = numberOfEmployee;
        }

        public override double TaxesPaid()
        {
            if (NumberOfEmployee > 10)
            {
                return AnualIncomes * 0.14;
            }

            else
            {
                return AnualIncomes * 0.16;
            }
        }
    }
}
