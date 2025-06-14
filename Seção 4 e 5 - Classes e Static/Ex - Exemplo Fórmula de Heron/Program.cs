using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Ex___Exemplo_Fórmula_de_Heron
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Triangulo  x, y;

            x = new Triangulo();
            y = new Triangulo();

            Console.WriteLine("Entre com as medidas do triângulo X:");
            x.A = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            x.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            x.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double areaX = x.Area();

            Console.WriteLine("Entre com as medidas do triângulo Y:");
            y.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            y.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            y.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


            double areaY = y.Area();

            Console.WriteLine($"A área do Triângulo X é: " + areaX.ToString("F4", CultureInfo.InvariantCulture));
            Console.WriteLine($"A área do Triângulo Y é: " + areaY.ToString("F4", CultureInfo.InvariantCulture));

            if (areaX > areaY)
            {
                Console.WriteLine("O maior triângulo é o X");
            }
            else
            {
                Console.WriteLine("O maior triângulo é o Y");
            }


            Console.ReadKey();
        }
    }
}
