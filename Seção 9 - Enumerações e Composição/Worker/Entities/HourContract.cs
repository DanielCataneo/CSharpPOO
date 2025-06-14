using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Worker.Entities
{
    internal class HourContract
    {
        public DateTime Date;
        public Double ValuePerHour;
        public int Hours;

        public HourContract(DateTime date, double valuePerHour, int hour)
        {
            Date = date;
            ValuePerHour = valuePerHour;
            Hours = hour;
        }

        public double TotalValue()
        {
            return ValuePerHour * Hours;
        }
        

    }
}
