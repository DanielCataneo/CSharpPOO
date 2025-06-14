using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;
using Exercício_de_Fixação.Entities.Enums;
using Microsoft.Win32.SafeHandles;

namespace Exercício_de_Fixação.Entities
{
    internal class Order
    {
        public DateTime Moment { get; set; }
        
        public OrderStatus Status { get; set; }

        public Client Client { get; set; }
        
        public List<OrderItem> Itens { get; set; } = new List<OrderItem>();

        


        public Order(DateTime moment, OrderStatus status, Client client)
        {
            Moment = moment;
            Status = status;
            Client = client;
        }


        


         public Order() { }


        public void AddItem(OrderItem item)
        {
            Itens.Add(item);
        }

        public void RemoveItem(OrderItem item)
        {
            Itens.Remove(item);
        }

        

        public double Total(OrderItem item)
        {
            return item.Price * item.Quantity;

        }

        public double Total()
        {
            double sum = 0.0;
            foreach (OrderItem item in Itens)
            {
                sum += item.SubTotal();
            }
            return sum;
        }
        
        
        public override string ToString()
        {
            
            StringBuilder sb = new StringBuilder();
        
            sb.AppendLine("Order Moment: " + Moment.ToString("dd/MM/yyyy HH:mm:ss"));
            sb.AppendLine("Order status: " + OrderStatus.Processing);
            sb.AppendLine("Client: " +  Client.Name+ ", " + Client.Email + " - " + Client.BirthDate.ToString("dd/MM/yyyy"));
            sb.AppendLine("Order itens");
            
            foreach (OrderItem item in Itens)
            {
                sb.AppendLine(item.ToString());
            }


            sb.AppendLine("Total price: $" + Total().ToString("F2", CultureInfo.InvariantCulture));
            return sb.ToString();
        }


    }
}
