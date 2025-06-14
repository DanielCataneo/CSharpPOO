using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Worker.Entities;
using Worker.Entities.Enums;
using System.Globalization;



namespace Exercicio_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
             
            Console.Write("Enter Department's Name: ");
            string DPname = Console.ReadLine();

            Console.WriteLine("Enter the Worker's Data:");
            Console.Write("Name: ");
            string name = Console.ReadLine();

            Console.Write("Level Junior/MidLevel/Senior: ");
            WorkerLevel level;
            Enum.TryParse(Console.ReadLine(), out level);
            

            Console.Write("Base Salary: ");
            double Bsalary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Department dept = new Department(DPname);
            Workers worker = new Workers(name ,level , Bsalary,  dept); 

            Console.Write("How many contracts did this worker: ");
            int contracts = int.Parse(Console.ReadLine());

            for (int i = 0; i < contracts; i++)
            {
                Console.WriteLine($"Enter #{i+1} contract data: ");
                Console.Write("Date (DD/MM/YYYY): ");
                DateTime date = DateTime.Parse(Console.ReadLine()); 
                
                Console.Write("Value per hour: ");
                double valuePerhour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                
                Console.Write("Duration (Hours): ");
                int hour = int.Parse(Console.ReadLine());

                HourContract H = new HourContract(date, valuePerhour, hour);
                worker.addContract(H);
            }

            Console.Write("Enter Month and Year to calculate the income (MM/YYYY) : ");
            string MandY = Console.ReadLine();
           
            int month = int.Parse(MandY.Substring(0,2));
            int year = int.Parse(MandY.Substring(3));



            Console.WriteLine();
            Console.WriteLine("Name: " + worker.Name);
            Console.WriteLine("Department: " + worker.Department.Name);
            Console.WriteLine("Income for " + MandY + " :" + worker.Income(year , month));

            Console.ReadKey();










        }
    }
}
