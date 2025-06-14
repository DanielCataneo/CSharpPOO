using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using Exercício_1___Herança.Entities;

namespace Exercício_1___Herança
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>();

            Console.Write("Enter the number of employees: ");


            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine("Employee " + i + "# data");
                Console.Write("Outsourced (y/n): ");
                char opcao = char.Parse(Console.ReadLine().ToUpper());

                if (opcao == 'Y')
                {
                    Console.Write("Name: ");
                    string name = Console.ReadLine();

                    Console.Write("Hours: ");
                    int hours = int.Parse(Console.ReadLine());

                    Console.Write("Value per Hour: ");
                    double value = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    Console.Write("AdditionalCharge: ");
                    double ad = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    OutSourcedEmployee outSourcedEmployee = new OutSourcedEmployee(name, hours, value, ad);
                    employees.Add(outSourcedEmployee);
                }


                else if (opcao == 'N')
                {
                    Console.Write("Name: ");
                    string name = Console.ReadLine();

                    Console.Write("Hours: ");
                    int hours = int.Parse(Console.ReadLine());

                    Console.Write("Value per Hour: ");
                    double value = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    Employee employee = new Employee(name, hours, value);
                    employees.Add(employee);
                }

            }

            Console.WriteLine("PAYMENTS: ");

            foreach (Employee employee in employees)
            {
                Console.WriteLine(employee.Name + " - $" + employee.Payment().ToString("f2", CultureInfo.InvariantCulture));
            }

            Console.ReadKey();
        }
    }
}
