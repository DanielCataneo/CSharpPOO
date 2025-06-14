using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operações_com_DateTime
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime d1 = new DateTime(2024, 07, 06, 19, 06, 40);
            Console.WriteLine(d1);

            DateTime d = new DateTime(2024, 07, 10, 19, 06, 40); 

            // Para adicionar dias a data
            DateTime d2 = d1.AddDays(1);
            Console.WriteLine(d2);

            // Para adicionar horas 
            DateTime d3 = d1.AddHours(3);
            Console.WriteLine(d3);

            // Para adicionar minutos
            DateTime d4 = d1.AddMinutes(4);
            Console.WriteLine(d4);

            // Para subtrair as datas
            TimeSpan t = d.Subtract(d1);
            Console.WriteLine(t);
            


            Console.ReadKey();

        }
    }
}
