using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_5___else.@if
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Double C1 = 4.00, C2 = 4.50, C3 = 5.00, C4 = 2.00, C5 = 1.50;

            
            Console.WriteLine("C1 = Cachorro Quente R$4.00");
            Console.WriteLine("C2 = X-Salada R$4.50");
            Console.WriteLine("C3 = X-Bacon R$5.00");
            Console.WriteLine("C4 = Torrada simples R$2.00");
            Console.WriteLine("C5 = Refrigerante R$1.50");

            Console.WriteLine("Qual o código do produto que deseja comprar?: ");
            int codigo = int.Parse(Console.ReadLine());

            Console.WriteLine("Qual a quantidade que deseja desse produto?:");
            int qtd = int.Parse(Console.ReadLine());

            if (codigo == 1 ) 
            {
                Console.WriteLine($"O valor a pagar é R${C1 * qtd}");            
            }
           
            else if (codigo == 2)
            {
                Console.WriteLine($"O valor a pagar é R${C2 * qtd}");
            } 
            
            else if (codigo == 3) 
            {
                Console.WriteLine($"O valor a pagar é R${C3 * qtd}");
            }
            else if (codigo == 4)
            {
                Console.WriteLine($"O valor a pagar é R${C4 * qtd}");
            }
            else if (codigo == 5)
            {
                Console.WriteLine($"O valor a pagar é R${C5 * qtd}");
            }

            Console.ReadKey();
        }
    }
}
