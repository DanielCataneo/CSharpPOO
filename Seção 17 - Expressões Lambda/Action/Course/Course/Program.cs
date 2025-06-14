using Course.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course
{
    internal class Program
    {
        /*Fazer um programa que, a partir de uma lista de produtos, aumente o
          preço dos produtos em 10.0%
         * 
         */

        static void Main(string[] args)
        {
            List<Product> list = new List<Product>();
           
            
            list.Add(new Product("Tv", 900.00));
            list.Add(new Product("Mouse", 50.00));
            list.Add(new Product("Tablet", 350.50));
            list.Add(new Product("HD Case", 80.90));


            //               Action
            list.ForEach(p => { p.Price += p.Price * 0.1; }) ;
            foreach (Product p in list)
            {
                Console.WriteLine(p);
            }

            Console.ReadKey();

        }
    }
}
