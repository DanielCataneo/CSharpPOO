using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Ex_2___Prog.Objetos
{
    public class Program
    {
        static void Main(string[] args)
        {
            pessoa pessoa1 = new pessoa();
            pessoa pessoa2 = new pessoa();

            Console.WriteLine("Escreva o nome do 1º Funcionário: ");
            pessoa1.Nome = Console.ReadLine();
            Console.WriteLine("Escreva o salário do 1º Funcionário: ");
            pessoa1.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Escreva o nome do 2º Funcionário: ");
            pessoa2.Nome = Console.ReadLine();
            Console.WriteLine("Escreva o salário do 2º Funcionário: ");
            pessoa2.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double mediasalario = (pessoa1.Salario + pessoa2.Salario) / 2 ;

            Console.Write("A média salarial dos funcionários é: " +  mediasalario.ToString("F2", CultureInfo.InvariantCulture));

            Console.ReadKey();
        }

    }
}
