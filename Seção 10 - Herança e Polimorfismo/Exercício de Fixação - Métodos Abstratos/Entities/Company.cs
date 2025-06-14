using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_de_Fixação___Métodos_Abstratos.Entities
{
    class Company : TaxPayer
    {
        public  int NumberOfEmployees { get; set; }

        public Company() { }

        public Company(string name, double anualIncome, int numberofemployees) : base ( name, anualIncome)
        {
            NumberOfEmployees = numberofemployees;
        }

        public override double Tax()
        {
            if ( NumberOfEmployees >10)
            {
                return AnualIncome * 0.14;
            }

            else
            {
                return AnualIncome * 0.16;
            }
                
                    
         }

        

    }
}
