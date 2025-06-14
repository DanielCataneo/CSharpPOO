using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.Net;

namespace Exemplo___Versão_1
{
    internal class Program
    {
        

        static void Main(string[] args)
        {
            Calculadora calc = new Calculadora();                

            Console.Write("Digite o valor do raio: ");
            double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double circ = calc.Circunferencia(raio);
            double volume = calc.Volume(raio);
            
            Console.WriteLine("O valor da circunferência é: " + circ.ToString("F2" , CultureInfo.InvariantCulture));
            Console.WriteLine("O valor do volume é: " + volume.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Valor de pi: "  + calc.Pi.ToString("F2", CultureInfo.InvariantCulture));


            Console.ReadKey();

        }



        
    }
}
