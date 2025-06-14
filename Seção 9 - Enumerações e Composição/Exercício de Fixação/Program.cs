using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exercício_de_Fixação.Entities;
using Exercício_de_Fixação.Entities.Enums;
using System.Globalization;

namespace Exercício_de_Fixação
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Client data: ");
            Console.Write("Name: ");
            string name = Console.ReadLine();

            Console.Write("Email: ");
            string email = Console.ReadLine();

            Console.Write("Birth Date (dd/MM/yyyy): ");
            DateTime dateTime = DateTime.Parse(Console.ReadLine());

            Client client = new Client(name, email, dateTime);
           



            Console.WriteLine("Enter order data");
           
            Console.WriteLine("Status: ");
            OrderStatus orderStatus;
            Enum.TryParse("Processing" , out orderStatus);
            
            Order order = new Order(DateTime.Now, orderStatus, client);



            Console.Write("How many products to this Data: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Enter #{i + 1} item data: ");
                Console.Write("Product name: ");
                string productname = Console.ReadLine();
                
                Console.Write("Product price: ");
                double productprice = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Product product = new Product(productname, productprice);
                
                Console.Write("Quantity: ");
                int quantity = int.Parse(Console.ReadLine());

                Console.WriteLine();

                OrderItem order1 = new OrderItem(quantity, productprice ,product);

                order.AddItem(order1);
            }


            Console.WriteLine();
            Console.WriteLine("ORDER SUMMARY:");
            Console.WriteLine(order);

            Console.ReadKey();




        }
    }
}
