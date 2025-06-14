using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Expressão_Condicional_Ternária
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Estrutura da Expressão Condicional Ternária --> (condição) ? Valor_se_verdadeiro : Valor_se_falso           
            
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double desconto = (preco < 20.0) ? preco * 0.1 : preco * 0.05;

            Console.WriteLine("O desconto foi de: " + desconto);

            Console.ReadKey();
        }
    }
}
