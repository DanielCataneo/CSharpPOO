﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exercício_de_Fixação___Métodos_Abstratos.Entities;

namespace Exercício_de_Fixação___Métodos_Abstratos.Entities
{
    class Individual : TaxPayer
    {
        public double HealthExpenditures { get; set; }

        public Individual() { }

        public Individual(string name , double anualIncome, double healthExpenditures) : base(name , anualIncome)
        {
            HealthExpenditures = healthExpenditures;
        }


        public override double Tax()
        {
            if (AnualIncome < 20000.00)
            {
                return  (AnualIncome * 0.15) - (HealthExpenditures * 0.5);
            }

            else
            {
                return  (AnualIncome * 0.25 - HealthExpenditures * 0.5);
            }
        }
    }

}
