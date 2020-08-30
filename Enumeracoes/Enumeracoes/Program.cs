using Enumeracoes.Entities;
using Enumeracoes.Entities.Enums;
using System;

namespace Enumeracoes
{
    class Program
    {
        static void Main(string[] args)
        {
            Order pedido = new Order { Id = 80, Moment = DateTime.Now, Status = OrderStatus.Delivered };

            Console.WriteLine(pedido);

            //Converter Enum em String

            string txt = OrderStatus.PendingPayment.ToString();
            

            Console.WriteLine(txt);
        }
    }
}
