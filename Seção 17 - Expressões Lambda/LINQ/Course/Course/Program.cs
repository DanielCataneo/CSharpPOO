﻿using System;
using System.Collections.Generic;
using System.Linq;


namespace Course
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Specify the data source.
            int[] numbers = new int[] { 2, 3, 4, 5 };

            // Define the query expression.
            
            // var also works
            IEnumerable<int> result = numbers
            .Where(x => x % 2 == 0)
            .Select(x => 10 * x);

                
            // Execute the query.
            foreach (int x in result)
            {
                Console.WriteLine(x);

            }

            Console.ReadKey();
        }
    }
}