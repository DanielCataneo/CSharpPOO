using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Globalization;
using System.Xml.Linq;
using System.Runtime.Remoting.Services;

namespace Exercício_de_fixação___Listas
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
           
            double N;

            Console.Write("How many employees will be registered: ");
            N = int.Parse(Console.ReadLine());

            // Declara a classe dentro da Lista
            List<Employee> list = new List<Employee>();



            for (int i = 0; i < N; i++)
            {
                Console.Write("Employee #" + (i + 1) + ":" + " ID: ");
                string id = (Console.ReadLine());

                Console.Write("Name: ");
                string name = Console.ReadLine();

                Console.Write("Salary: ");
                double salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                // Cria uma nova instância da classe Employee usando o construtor que aceita três argumentos
                list.Add(new Employee(id, name, salary));
                // Este método adiciona o novo objeto Employee criado à lista.
                
                Console.WriteLine();
            }

            Console.Write("Enter the employee ID that will have salary increased: ");
            string newId = Console.ReadLine();

            // Procura dentro da lista por um Id igual 
            Employee employee = list.Find(x  => x.Id == newId);
            
                if (employee != null)
                {
                    Console.Write("Enter the percentage: ");
                    double percentage = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    employee.increaseSalary(percentage);
                }
                else
                Console.WriteLine("This employee do not exist");

            Console.WriteLine();
            Console.WriteLine("Uptaded list of employees: ");
            
                foreach ( Employee emp in list)
                {
                Console.WriteLine(emp);
                
                }
          



            Console.ReadKey();

        }
    }
}
