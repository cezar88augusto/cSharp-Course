using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace AssociacaoProjeto3.Entities
{
    class Order
    {
        public DateTime moment { get; set; }
        public OrderStatus status { get; set; }
        public Client client { get; set; }

        public List<OrderItem> items = new List<OrderItem>();

        public Order(DateTime moment, OrderStatus status, Client client)
        {
            this.moment = moment;
            this.status = status;
            this.client = client;
        }

        public void addItem(OrderItem item)
        {
            items.Add(item);
        }

        public void removeItem (OrderItem item)
        {
            items.Remove(item);
        }

        public double total()
        {
            double totalList = 0;

            foreach (OrderItem item in items)
            {
                totalList += item.price * item.quantity;
            }

            return totalList;
        }

        public override string ToString()

        {

            StringBuilder sb = new StringBuilder();

            sb.AppendLine("Order moment: " + moment.ToString("dd/MM/yyyy HH:mm:ss"));

            sb.AppendLine("Order status: " + status);

            sb.AppendLine("Client: " + client);

            sb.AppendLine("Order items:");

            foreach (OrderItem item in items)

            {

                sb.AppendLine(item.ToString());

            }

            sb.AppendLine("Total price: $" + total().ToString("F2", CultureInfo.InvariantCulture));

            return sb.ToString();

        }



    }
}
