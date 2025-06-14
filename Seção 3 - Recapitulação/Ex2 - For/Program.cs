using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Ex2___For
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N = 0;
            int X  = 0;
            int dentro = 0;
            int fora = 0;
            
            
            Console.WriteLine("Quantos valores de N você deseja digitar?:");
            N = int.Parse(Console.ReadLine());

            for (int i = 0; i < N; i++) 
            {
                Console.WriteLine("Digite os números X: ");
                X = int.Parse(Console.ReadLine());

                if (X >= 10 && X <= 25)
                {
                    dentro++;
                }
                
                else
                {
                    fora++;
                }  
            }

            Console.WriteLine(dentro + ":In");
            Console.WriteLine(fora + ":Out");

            Console.ReadKey();
        }
    }
}
