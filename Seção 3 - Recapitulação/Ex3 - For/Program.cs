using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex3___For
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N ;

            Console.WriteLine("Quantos testes N você deseja fazer?: ");
            N = int.Parse(Console.ReadLine());

            for (int i = 0; i < N; i++) 
            {
                Console.Write("Digite os 3 números para a média ponderada: ");
                double n1 = double.Parse(Console.ReadLine());

                Console.Write("Digite os 3 números para a média ponderada: ");
                double n2 = double.Parse(Console.ReadLine());

                Console.Write("Digite os 3 números para a média ponderada: ");
                double n3 = double.Parse(Console.ReadLine());

                double mediaP = (n1 * 2 + n2 * 3 + n3 * 5) / 10;

                Console.WriteLine($"A média ponderada dos Números {n1:F1}, {n2:f1} e {n3:f1} é {mediaP:f1} ");



            }

            Console.ReadLine();


        }
    }
}
