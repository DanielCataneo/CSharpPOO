using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex_6___else.@if
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite um número qualquer de 0 à 100: ");
            float numero = float .Parse(Console.ReadLine());

            if (numero >= 0 && numero <= 25 ) 
            {
                Console.WriteLine("Esse número está no intervalo de [0 , 25]");
            }

            else if (numero > 25 &&  numero <= 50)
            {
                Console.WriteLine("Esse número está no intervalo de [25 , 50]");
            }

            else if (numero > 50 && numero <= 75)
            {
                Console.WriteLine("Esse número está no intervalo de [50 , 75]");
            }

            else if (numero > 75 && numero <= 100)
            {
                Console.WriteLine("Esse número está no intervalo de [75 , 100]");
            }
            
            else
            {
                Console.WriteLine("Esse número não se encontra em nenhum desses intervalos!!");
            }

            Console.ReadKey();
        }
    }
}
