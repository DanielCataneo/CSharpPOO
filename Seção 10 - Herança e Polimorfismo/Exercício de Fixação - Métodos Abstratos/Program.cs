using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using Exercício_de_Fixação___Métodos_Abstratos.Entities;
using System.Linq.Expressions;
using System.Runtime.Serialization;

namespace Exercício_de_Fixação___Métodos_Abstratos
{
    internal class Program
    {
        static void Main(string[] args)
        {
           List<TaxPayer> taxPayers = new List<TaxPayer>();



            Console.Write("Enter the number of Tax payers: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Tax payer #{i} Data ");

                Console.Write("Individual or Company (i/c): ");
                char opcao = char.Parse(Console.ReadLine().ToUpper());

                Console.Write("Name: ");
                string name = Console.ReadLine();

                Console.Write("Annual Income: ");
                double amount = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if (opcao == 'I')
                {
                    Console.Write("Health expenditures: ");
                    double he = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    taxPayers.Add(new Individual(name , amount , he));
                }

                else if ( opcao == 'C')
                {
                    Console.Write("Number of employees: ");
                    int emp = int.Parse(Console.ReadLine());

                   taxPayers.Add(new Company (name , amount , emp));
                }

                Console.WriteLine();
            }

            double soma = 0.0;
            Console.WriteLine("TAXES PAID");

            foreach (TaxPayer taxPayer in taxPayers)
            {
                Console.WriteLine(taxPayer.Name + ":  $ " + taxPayer.Tax().ToString("F2", CultureInfo.InvariantCulture));
                soma += taxPayer.Tax();
            }

            Console.WriteLine();
            Console.WriteLine("TOTAL TAXES:  $ " + soma.ToString("f2", CultureInfo.InvariantCulture));

            Console.ReadKey();
        }
    }
}
