using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Net;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;
using Worker.Entities.Enums;
using Worker.Entities;


namespace Worker.Entities
{
    internal class Workers
    {
        public  string Name { get; set; }
        public double BaseSalary { get; set; }
        public int Level { get; set; }

        public Department Department { get; set; }

        public List<HourContract> Contracts { get; set; } = new List<HourContract>();

        public Workers(string name, WorkerLevel level, double baseSalary, Department department)
        {
            Name = name;
            BaseSalary = baseSalary;
            Level = (int)level;
            Department = department;
            
        }

        public void addContract(HourContract contract)
        {
            Contracts.Add(contract);
        }

        public void removeContract(HourContract contract)
        {
            Contracts.Remove(contract);
        }

        public double Income(int year, int month)
        {
            double sum = BaseSalary;
            foreach(HourContract contract in Contracts)
            {
                if (contract.Date.Year == year && contract.Date.Month == month)
                    sum += contract.TotalValue();
                    
            }
            return sum;
        }
            


    }
}
