using System;
using System.Collections.Generic;
using Course.Entities;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<Product> products = new HashSet<Product>();

            products.Add(new Product("Tv", 900.0));
            products.Add(new Product("Notebook", 1200.0));

          

            // Necessário Implementar o GetHashCode e Equals na classe para comparar referências
            Product p = new Product("Notebook", 1200.0);
            Console.WriteLine(products.Contains(p));

            HashSet<Point> points = new HashSet<Point>();
            points.Add(new Point(3, 4));
            points.Add(new Point(5, 10));

            // Classes tipo struct NÃO necessitam dessa implementação
            Point pont = new Point(3, 4);
            Console.WriteLine(points.Contains(pont));




            Console.ReadKey();

        }
    }
}
