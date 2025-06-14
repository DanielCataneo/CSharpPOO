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
        // Fazer um programa que, a partir de uma lista de produtos, gere uma
        // nova lista contendo os nomes dos produtos em caixa alta.

        static void Main(string[] args)
        {

            List<Product> list = new List<Product>();
            list.Add(new Product("Tv", 900.00));
            list.Add(new Product("Mouse", 50.00));
            list.Add(new Product("Tablet", 350.50));
            list.Add(new Product("HD Case", 80.90));

            Func<Product , string> func = p => p.Name.ToUpper();
            //   Select                                 Lambda
            List<string> list2 = list.Select(p => p.Name.ToUpper()).ToList();

            foreach (string s in list2)
            {
                Console.WriteLine(s);
            }

            Console.ReadKey();
        }
    }
}
