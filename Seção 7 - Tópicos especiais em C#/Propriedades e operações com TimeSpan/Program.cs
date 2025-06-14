using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Propriedades_e_operações_com_TimeSpan
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TimeSpan t = new TimeSpan(1, 30, 10);
            TimeSpan t1 = new TimeSpan(0, 1, 05);

            // Para somar os dois valores
            TimeSpan soma = t.Add(t1);
            Console.WriteLine(soma);

            // Para subtrair os dois valores
            TimeSpan dif = t.Subtract(t1);
            Console.WriteLine(dif);

            Console.ReadKey();

        }


    }
}




