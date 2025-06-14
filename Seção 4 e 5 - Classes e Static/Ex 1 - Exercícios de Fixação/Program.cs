using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Ex_1___Exercícios_de_Fixação
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Retangulo retangulo = new Retangulo();

            Console.Write("Digite o valor da largura do retângulo: ");
            retangulo.Largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Digite o valor da altura do retângulo: ");
            retangulo.Altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine($"Area = {retangulo.Area()}");
            Console.WriteLine($"Perimetro = {retangulo.Perimetro()}");
            Console.WriteLine($"Diagonal = {retangulo.Diagonal()}");

            Console.ReadKey();
        }
    }
}
