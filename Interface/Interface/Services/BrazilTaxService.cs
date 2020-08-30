using System;
using System.Collections.Generic;
using System.Text;

namespace Interface.Services
{
    class BrazilTaxService : ITaxService //Não é herança, É UMA INTERFACE.
    {
        public double Tax(double amount) //Mesmo nome do método da INTERFACE
        {

            if (amount <= 100.00)
            {
                return amount * 0.2;
            }

            else
            {
                return amount * 0.15;
            }

        }
    }
}
