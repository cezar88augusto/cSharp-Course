using System;
using System.Collections.Generic;
using System.Text;

namespace Polimorfismo.Entities
{
    class UsedProduct : Product
    {
        public DateTime MyProperty { get; set; }
        public UsedProduct()
        {
        }



        public UsedProduct(string name, double price, DateTime myProperty) : base (name, price)
        {
            MyProperty = myProperty;
        }

        public override string priceTag()
        {
            return name + "(used)" + " $ " + price + "(Manufacture date: " + MyProperty +")";
        }
    }
}
