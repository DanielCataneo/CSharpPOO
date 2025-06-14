using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Exercício_de_Fixação_Static
{
    internal class Program
    {
        static void Main(string[] args)
        {

            ConversorDeMoeda convert = new ConversorDeMoeda();

            Console.Write("Qual o valor do dolar: ");
            double Vdolar = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Quantos dolares deseja comprar: ");
            double Quantia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


            double valorT = ConversorDeMoeda.Multiplicador(Vdolar, Quantia);
            
            Console.WriteLine("O valor a pagar será de: "  +  valorT.ToString("f2" , CultureInfo.InvariantCulture));

            Console.ReadKey();
            
        }
    }
}
