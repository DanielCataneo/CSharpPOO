using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.Net.Http.Headers;

namespace Problema_Ex_1___Vetor
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int N;
            

            Console.Write("Digite a quantidade de pessoas: ");
            N = int.Parse(Console.ReadLine());

            double[] vetor = new double[N];
            
            for (int i = 0; i < N; i++)
            {

                Console.WriteLine("Digite a Altura: ");
                vetor[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            }

            double soma = 0.0;

            for (int i = 0; i < N; i++)
            {
                soma += vetor[i];
            }

            Console.WriteLine("A média dos pesos é: " + (soma / N).ToString("f2"  , CultureInfo.InvariantCulture));

            Console.ReadKey();



        }
    }
}
