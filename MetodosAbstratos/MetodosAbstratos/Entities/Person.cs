using System;
using System.Collections.Generic;
using System.Text;

namespace MetodosAbstratos.Entities
{
    abstract class Person
    {
        public string Name { get; set; }
        public double AnualIncomes { get; set; }

        protected Person()
        {
        }

        protected Person(string name, double anualIncomes)
        {
            Name = name;
            AnualIncomes = anualIncomes;
        }

        public abstract double TaxesPaid(); 
    }
}
