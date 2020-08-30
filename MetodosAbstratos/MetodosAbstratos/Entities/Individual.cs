using System;
using System.Collections.Generic;
using System.Text;



namespace MetodosAbstratos.Entities
{
    class Individual : Person
    {
        public double HealthExpenditures { get; set; }

        public Individual()
        {
        }

        public Individual(string name, double anualIncomes, double healthExpenditures) : base(name, anualIncomes)
        {
            HealthExpenditures = healthExpenditures;
        }

        public override double TaxesPaid()
        {
            if (AnualIncomes < 20000.0)
            {

                return AnualIncomes * 0.15 - HealthExpenditures * 0.5;

            }

            else
            {

                return AnualIncomes * 0.25 - HealthExpenditures * 0.5;

            }
        }



    }
}
