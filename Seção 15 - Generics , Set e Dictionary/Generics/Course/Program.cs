using Course.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("How many numbers: ");
            int n = int.Parse(Console.ReadLine());

            PrintService<int> p = new PrintService<int>();

            for (int i = 0; i < n; i++)
            {
                int number = int.Parse(Console.ReadLine());

                p.AddValue(number);
            }

            p.Print();

            Console.WriteLine("First: " + p.First());
           


            Console.ReadKey();
        }
    }
}
