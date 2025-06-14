using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using Exercício_de_Fixação.Entities;
using Exercício_de_Fixação.Entities.Exceptions;

namespace Exercício_de_Fixação
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter account data: ");

                Console.Write("Number: ");
                int number = int.Parse(Console.ReadLine());

                Console.Write("Holder: ");
                string name = Console.ReadLine();

                Console.Write("Initial balance: ");
                double balance = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Console.Write("Withdraw limit: ");
                double withlimit = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Console.WriteLine();
                
                Account account = new Account(number, name, balance, withlimit);

                Console.Write("Enter amount for withdraw: ");
                double withdraw = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                account.Withdraw(withdraw);

                Console.WriteLine();

                Console.WriteLine("New Balance: " + account.Balance.ToString("f2" , CultureInfo.InvariantCulture));
                Console.WriteLine(account);
            }

            catch (DomainException e ) 
            { 
                Console.WriteLine("Withdraw Error: " + e.Message);            
            
            }

            Console.ReadKey();
        }
    }
}
