using System;
using System.Collections.Generic;
using System.Text;

namespace Polimorfismo.Entities
{
    class Product
    {
        public string name { get; set; }
        public double price { get; set; }

        public Product()
        {
        }

        public Product(string name, double price)
        {
            this.name = name;
            this.price = price;
        }

        public virtual string priceTag()
        {
            return name + " - $ " + this.price;
        }
    }
}
