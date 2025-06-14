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
            //D:\Daniel\Curso C#\Programação Orientada a Objetos\Seção 17 - Expressões Lambda\Exercício de Fixação\in.txt

            try
            {
                Console.Write("Enter the file full path: ");
                string path = Console.ReadLine();

                Console.Write("Enter salary: ");
                double salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                List<Employee> emp = new List<Employee>();

                using (StreamReader sr = File.OpenText(path))
                {
                    while (!sr.EndOfStream)
                    {
                        string[] lines = sr.ReadLine().Split(',');

                        string name = lines[0];
                        string email = lines[1];
                        double empsalary = double.Parse(lines[2], CultureInfo.InvariantCulture);

                        emp.Add(new Employee(name, email, empsalary));
                    }
                }

                Console.WriteLine("Email of people whose salary is more than " + salary.ToString("f2", CultureInfo.InvariantCulture));

                var emails = emp.Where(e => e.Salary > salary).OrderBy(e => e.Name).Select(e => e.Email);

                foreach (var email in emails)
                {
                    Console.WriteLine(email);
                }

                Console.Write("Sum of salary of people whose name starts with 'M': ");

                var Sum = emp.Where(e => e.Name[0] == 'M').Select(e => e.Salary).Sum();
                Console.Write(Sum.ToString("f2"), CultureInfo.InvariantCulture);

            }catch(IOException e)
            {
                Console.WriteLine("An error ocurred: " + e.Message);
            }
            Console.ReadKey();



        }
    }
}
