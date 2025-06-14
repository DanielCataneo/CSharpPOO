using System;
using System.Globalization;

namespace Course.Entities
{
    internal class Employee : IComparable
    {
        public string Name { get; set; }
        public double Salary { get; set; }

        public Employee(string csvEmployee) {
            string[] vet = csvEmployee.Split(',');
            Name = vet[0];
            Salary = double.Parse(vet[1] , CultureInfo.InvariantCulture);
        }

        public override string ToString()
        {
            return Name + ", " + Salary.ToString("f2", CultureInfo.InvariantCulture); 
        }

        //Compara os objetos dentro de uma lista com base no tamanho de ambos
        public int CompareTo(object obj)
        {
            if(!(obj is Employee)){
                throw new ArgumentException("Argument is not Employee");
            }

            Employee other = obj as Employee;
            return Salary.CompareTo(other.Salary);
        }
    }
}
