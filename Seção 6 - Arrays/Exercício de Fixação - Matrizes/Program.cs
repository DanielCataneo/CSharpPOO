using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_de_Fixação___Matrizes
{
    internal class Program
    {
        static void Main(string[] args)
        {


            Console.Write("Digite o formato da sua matriz da matriz: ");
            string[] formato = (Console.ReadLine().Split(' '));

            int m = int.Parse(formato[0]);
            int n = int.Parse(formato[1]);



            int[,] matriz = new int[m, n];

            for (int i = 0; i < m; i++)
            {
                string[] numeros = Console.ReadLine().Split(' ');

                for (int j = 0; j < n; j++)
                {
                    matriz[i, j] = int.Parse(numeros[j]);
                }
            }

            Console.Write("Digite o número: ");
            int num = int.Parse(Console.ReadLine());

            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (matriz[i, j] == num)
                    {
                        Console.WriteLine("Position --> " + i + ", " + j);

                        if (j > 0)
                        {
                            Console.WriteLine("Number to the left: " + matriz[i, j - 1]);
                        }

                        if (i > 0)
                        {
                            Console.WriteLine("Number up: " + matriz[i - 1, j]);
                        }

                        if (j < n - 1)
                        {
                            Console.WriteLine("Number right:" + matriz[i, j + 1]);
                        }

                        if (i < m - 1)
                        {
                            Console.WriteLine("Number down: " + matriz[i + 1, j]);
                        }
                    }
                   
                }
            }


            Console.ReadKey();

        }
    }
}
