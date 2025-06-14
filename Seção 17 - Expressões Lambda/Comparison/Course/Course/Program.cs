using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Course.Entities;

namespace Course
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Product> products = new List<Product>();

            products.Add(new Product("TV", 900.00));
            products.Add(new Product("Notebook", 1200.00));
            products.Add(new Product("Tablet", 450.00));

            // Expressão Lambda

            Console.WriteLine("COMPARAÇÃO POR NOME");
            products.Sort((p1, p2) => p1.Name.ToUpper().CompareTo(p2.Name.ToUpper()));

            foreach (Product p in products)
            {
                Console.WriteLine(p);
            }

            Console.WriteLine();
            Console.WriteLine("COMPARAÇÃO POR PREÇO");

            products.Sort( (p1, p2) => p1.Price.CompareTo(p2.Price));

            foreach (var item in products)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }
    }
}
