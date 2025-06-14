using Course.Entities;
using System;
using System.Collections.Generic;
using System.IO;

namespace Course
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = @"d:\Daniel\in.txt";

            try 
            {
                using (StreamReader sr = File.OpenText(path))
                {

                    List<Employee> lines = new List<Employee>();
                    while (!sr.EndOfStream)
                    {
                        lines.Add(new Employee(sr.ReadLine()));
                    }
                    
                    lines.Sort();
                    foreach (Employee emp in lines)
                    {
                        Console.WriteLine(emp);
                    }
                }  
            
            
            }
            catch (IOException ex) {
                Console.WriteLine("An errour ocurred");
                Console.WriteLine(ex.Message);
            }
            Console.ReadKey();
        }
    }
}
