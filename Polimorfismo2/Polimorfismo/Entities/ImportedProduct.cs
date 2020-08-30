using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Polimorfismo.Entities
{
    class ImportedProduct : Product
    {
        public double customsFee { get; set; }

        public ImportedProduct()
        {
        }

        public ImportedProduct(string name, double price, double customsFee) : base(name, price)
        {
            this.customsFee = customsFee;
        }

        public double totalPrice()
        {
            return price + customsFee;
        }

        public override string priceTag()
        {
            return name

        + " $ "

        + totalPrice().ToString("F2", CultureInfo.InvariantCulture)

        + " (Customs fee: $ "

        + customsFee.ToString("F2", CultureInfo.InvariantCulture)

        + ")";
        }
    }
}
