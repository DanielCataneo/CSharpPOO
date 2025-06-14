using System;
using System.Collections.Generic;
using System.Xml.Schema;
using Course.Entities;

namespace Course
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HashSet<int> CourseA = new HashSet<int>();
            HashSet<int> CourseB = new HashSet<int>();
            HashSet<int> CourseC = new HashSet<int>();



            Console.Write("How many students for course A: ");
            int a = int.Parse(Console.ReadLine());

            for (int i = 0; i < a; i++)
            {
                int Id = int.Parse(Console.ReadLine());
                CourseA.Add(Id);
            }

            Console.Write("How many students for course B: ");
            int b = int.Parse(Console.ReadLine());

            for (int i = 0; i < b; i++)
            {
                int Id = int.Parse(Console.ReadLine());
                CourseB.Add(Id);
            }
            
            Console.Write("How many students for course C: ");
            int c = int.Parse(Console.ReadLine());

            for (int i = 0; i < c; i++)
            {
                int Id = int.Parse(Console.ReadLine());
                CourseC.Add(Id);
            }

            // Ideia para considerar os números repetidos
            HashSet<int> all = new HashSet<int>(CourseA);
            all.UnionWith(CourseB);
            all.UnionWith(CourseC);

            Console.WriteLine("Total students: " + all.Count);

            Console.ReadKey();


        }
    }
}
