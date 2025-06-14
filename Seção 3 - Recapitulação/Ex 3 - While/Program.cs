using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_3___While
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int gasolina = 0;
            int alcool = 0;
            int diesel = 0;

          
            Console.WriteLine("1 - Alcool");
            Console.WriteLine("2 - Etanol ");
            Console.WriteLine("3 - Diesel ");
            Console.WriteLine("4 - Para fechar o Programa");

            Console.WriteLine("Qual tipo de combústivel deseja abastecer?:");
            int comb = int.Parse(Console.ReadLine());

            while (comb != 4)
            {
                Console.WriteLine("Qual tipo de combústivel deseja abastecer?:");
                comb = int.Parse(Console.ReadLine());

                if (comb == 1) 
                    gasolina = gasolina + 1;
                
                else if (comb == 2)
                    alcool = alcool + 1;
                
                else if (comb == 3)
                    diesel = diesel + 1;
                
                
            }
            

            Console.WriteLine("MUITO OBRIGADO");

            Console.WriteLine("Gasolina: " + gasolina);
            Console.WriteLine("Alcool: " + alcool);
            Console.WriteLine("Diesel: " + diesel);
            
            Console.ReadLine();



        }
    }
}
