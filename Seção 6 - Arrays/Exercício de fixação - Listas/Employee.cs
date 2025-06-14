using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.IO.Pipes;

namespace Exercício_de_fixação___Listas
{
    internal class Employee
    {
        public string Id { get; set; }
        public string Name { get; set; }

        public double Salary { get; set; }

        public Employee(string id, string name, double salary)
        {
            Id = id;
            Name = name;
            Salary = salary;
        }

        public void increaseSalary(double percentage)
        {
            Salary += Salary * percentage / 100;    
            return;
        }


        public override string ToString()
        {
            return Id + " , " + Name + " , " + Salary.ToString("F2" , CultureInfo.InvariantCulture);
        }
    }
}
