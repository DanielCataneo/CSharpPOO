using System;
using System.Collections.Generic;
using System.Globalization;
using Course.Entities;
using Course.Services;

namespace Course
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Product> list = new List<Product>();

            Console.Write("How many products: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] s = Console.ReadLine().Split(',');
                string name = s[0];
                double price = double.Parse(s[1], CultureInfo.InvariantCulture);

                list.Add(new Product(name , price));
            }

            Console.WriteLine("Max: ");

            CalculationService calculationService = new CalculationService();

            Product max = calculationService.Max(list);
            Console.Write(max);

            Console.ReadKey();
        }
    }
}
