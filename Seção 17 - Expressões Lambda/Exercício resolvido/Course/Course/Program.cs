using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Globalization;
using Course.Entities;


namespace Course
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // D:\Daniel\Curso C#\Programação Orientada a Objetos\Seção 17 - Expressões Lambda\Exercício resolvido\in.txt

            Console.Write("Enter the file full path: ");
            string path = Console.ReadLine();

            List<Product> prod = new List<Product>();

            using(StreamReader sr = File.OpenText(path))
            {
                while(!sr.EndOfStream)
                {
                    string[] lines = sr.ReadLine().Split(',');

                    string name = lines[0];
                    double value = double.Parse(lines[1], CultureInfo.InvariantCulture);  

                    prod.Add(new Product(name, value));

                }
            }

            var avgprice = prod.Select(p => p.Price).DefaultIfEmpty(0.0).Average();
            Console.WriteLine(avgprice.ToString("f2" , CultureInfo.InvariantCulture));

            var names = prod.Where(p => p.Price < avgprice).OrderByDescending(p => p.Name).Select(p => p.Name);
            foreach(string name in names)
            {
                Console.WriteLine(name);
            }

            

            Console.ReadKey();
        }
    }
}
