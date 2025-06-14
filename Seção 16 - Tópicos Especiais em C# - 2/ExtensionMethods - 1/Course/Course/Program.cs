using System;
using Course.Extensions;

namespace Course
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime dt = new DateTime(2024, 09, 09, 8, 7, 45);
            Console.WriteLine(dt.ElapsedTime());


            DateTime dt2 = new DateTime(2024, 10, 01, 8, 7, 45);
            Console.WriteLine(dt2.ElapsedTime());

            Console.ReadKey();

        }
    }
}
