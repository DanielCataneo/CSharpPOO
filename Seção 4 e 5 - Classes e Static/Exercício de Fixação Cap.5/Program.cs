using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Exercício_de_Fixação_Cap._5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Conta_Bancária cont;

            Console.Write("Digite o nome do titular da Conta: ");
            string nome = Console.ReadLine();

            Console.Write("Digite o número da conta: ");
            int numero = int.Parse(Console.ReadLine());

            Console.Write("Deseja fazer um depósito inicial, s/n ? ");
            char opcao = char.Parse(Console.ReadLine().ToUpper());

            if(opcao == 'S')
            {
                Console.Write("Qual o valor do depósito: ");
                double deposito = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                cont = new Conta_Bancária(numero , nome , deposito);
            }
            else
            {
                cont = new Conta_Bancária(numero, nome);
            }

            Console.WriteLine();
            Console.WriteLine("Dados da conta: " + cont);

            Console.Write("Quanto deseja depositar: ");
            double depositoN = double.Parse(Console.ReadLine() , CultureInfo.InvariantCulture);
            cont.Deposito(depositoN) ;
            
            Console.WriteLine("Dados Atualizados: " + cont);

            
            Console.Write("\nQuanto deseja sacar: ");
            double Saque = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture) ;
            cont.Saque(Saque) ;

            Console.WriteLine();
            Console.WriteLine("Dados Atualizados: " + cont);

            Console.ReadKey();


        }
    }
}
