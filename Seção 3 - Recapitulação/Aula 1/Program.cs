using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String produto1 = "Computaodor";
            String produto2 = "Mesa de Escritório";

            byte idade = 30;
            int codigo = 5290;
            char genero = 'M';

            double preco1 = 2100.0;
            double preco2 = 650.50;
            double medida = 53.234567;

            Console.WriteLine("Preços");
            Console.WriteLine($"Computador R${preco1:f2}");
            Console.WriteLine($"Mesa de Escritório R${preco2:f2}");

            Console.WriteLine($"Registro: {idade} anos de idade, códido {codigo} e gênero {genero}");

            Console.WriteLine($"{medida:F8}" );
            Console.WriteLine($"{medida:F3}");


            Console.ReadLine();



        }
    }
}
