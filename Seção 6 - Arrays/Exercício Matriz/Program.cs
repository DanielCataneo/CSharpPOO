using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_Matriz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numN = 0;
           
            Console.Write("Qual será a ordem da matriz: ");
            int n = int.Parse(Console.ReadLine());

            int[,] array = new int[n,n];


            // Para fazer a leitura das linhas da matriz 
            for (int i = 0; i < n; i++)
            {
                // Para separar os valores escritos pelo usuário  
                string[] valores = Console.ReadLine().Split(' ');



                // Para fazer a leitura das colunas da matriz 
                  for ( int j = 0; j < n; j++)
                {
                    // transformando os valores em números inteiros
                    array[i,j] = int.Parse(valores[j]);
                }
            }

           Console.WriteLine("Main diagonal: ");

           for ( int i  = 0; i < n; i++)
           {
                // Pega apenas os valores da diagonal da matriz
                Console.Write(array[i,i] + " ");
           }

            Console.WriteLine();

            // Leitura das linhas e colunas novamente para ler os números negativos
            for (int i = 0; i < n; i++)
            {

                for (int j = 0; j < n; j++)
                {

                    if (array[i, j] < 0)
                    {
                        numN++;
                    }

                }

            }
            Console.Write("Negative Numbers: " + numN);

            Console.WriteLine();

            Console.ReadKey();
           
            

        }
    }
}
