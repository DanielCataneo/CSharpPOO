using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_3___If.@else
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int A, B;

            Console.WriteLine("Digite um valor para o número A:");
            A = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite um valor para o número B: ");
            B = int.Parse(Console.ReadLine());
        
            if (A % B == 0) 
            {
                Console.WriteLine("Os números são múltiplos");
            }           
        
            else
                Console.WriteLine("Os números não são múltiplos");
            
            Console.ReadKey();
        }   


    }
}
