using System;
using System.Collections;
using System.Collections.Generic;
using System.IO.Ports;
using Course.Entities;

namespace Course
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Predicate: representa um método que recebe um objeto do tipo <T> e retorna um valor booleano

            /* Fazer um programa que, a partir de uma lista de produtos, remova da
             * lista somente aqueles cujo preço mínimo seja 100.00
            */
            
            List <Product> products = new List<Product>();

            products.Add(new Product("Tv", 900.00));
            products.Add(new Product("Mouse", 50.00));
            products.Add(new Product("Tablet", 350.50));
            products.Add(new Product("HD Case", 80.90));

            //                      Predicate
            products.RemoveAll(p => p.Price >= 100.0);
            foreach (Product p in products)
            {
                Console.WriteLine(p);


            }
            Console.ReadLine();
        }
    }
}
