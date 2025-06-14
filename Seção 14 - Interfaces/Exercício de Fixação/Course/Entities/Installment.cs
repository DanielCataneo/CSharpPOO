using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course.Entities
{
    internal class Installment
    {
        public DateTime DueTime { get; set; }   
        public double Amount { get; set; }

        public Installment(DateTime date , double amount) {
        
           DueTime = date;
            Amount = amount;
        }

        public override string ToString()
        {
            return DueTime.ToString("dd/MM/yyyy") + " - " + Amount.ToString("f2", CultureInfo.InvariantCulture);

        }


    }
}
