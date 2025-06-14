using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Enumerações.Entitites;
using Enumerações.Entitites.Enums;

namespace Enumerações
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Order order = new Order
            {
                Id = 1987,
                Moment = DateTime.Now,
                Status = OrderStatus.PendingPayment
                
            };

            Console.WriteLine(order);

            
            //Conversão de Número para string 

            string txt = OrderStatus.PendingPayment.ToString();
            Console.WriteLine(txt);

            // De String para número

            OrderStatus os;
            Enum.TryParse("Delivered", out os);

            Console.WriteLine(os);

            Console.ReadKey();


        }
    }
}
