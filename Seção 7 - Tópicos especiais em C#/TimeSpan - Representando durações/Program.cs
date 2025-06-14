using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeSpan___Representando_durações
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Construtor 
            TimeSpan t1 = new TimeSpan(0, 1, 30);
            Console.WriteLine(t1);

            // Construtor que Mostra os dias também
            TimeSpan t2 = new TimeSpan(10, 20, 30, 21);
            Console.WriteLine(t2);

            // Transforma frações em horas
            TimeSpan t3 = TimeSpan.FromHours(1.5);
            Console.WriteLine(t3);

            // Transforma frações de minutos
            TimeSpan t4 = TimeSpan.FromMinutes(1.5);
            Console.WriteLine(t4);

            // Transforma frações de segundos
            TimeSpan t5 = TimeSpan.FromSeconds(1.5);
            Console.WriteLine(t5);

            // Transforma frações em dias 
            TimeSpan t6 = TimeSpan.FromDays(1);
            Console.WriteLine(t6);

            // Transforma os ticks em horas
            TimeSpan t7 = TimeSpan.FromTicks(900000000L);
            Console.WriteLine(t7);

            DateTime D1 = new DateTime(2024, 10, 20);
            DateTime d2 = new DateTime(2024, 08, 26);

            TimeSpan ts = d2.Subtract(D1);
            Console.WriteLine(ts.Days);



            Console.ReadKey();

        }
    }
}
