using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex_4___For
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N;

            Console.WriteLine("Quantas divisões deseja fazer?: ");
            N = int.Parse(Console.ReadLine());

            for (int i = 0; i <= N; i++)
            {
                Console.Write("Digite os dois números que deseja dividir:  ");
                string[] num = Console.ReadLine().Split(' ');

               double n1 = double.Parse(num[0]);
               double n2 = double.Parse(num[1]);

                double divisao = n1 / n2;
                
                if( n2 == 0)
                {
                    Console.WriteLine("Impossível Dividir");
                }
                else
                    Console.WriteLine(divisao);

            }   

            Console.ReadKey();
        }
    }
}
