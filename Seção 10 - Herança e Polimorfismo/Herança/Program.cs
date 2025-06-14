using Herança.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Herança
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Account acc = new Account(1987, "Alex" , 100.0);
            BusinessAccount bacc = new BusinessAccount(1988, "Maria", 100.0, 200.0);
            
            // UPCASTING
    
            Account acc1 = bacc;
            Account acc2 = new BusinessAccount(1981, "Bob", 100.0, 100.0);
            Account acc3 = new SavingsAccount(12, "John", 100.0, 0.00);


            // DOWNCASTING

            // ERRO BusinessAccount acc5 = (BusinessAccount) acc3;

            if (acc3 is BusinessAccount)
            {
                // BusinessAccount acc5 = (BusinessAccount)acc3;
                
                BusinessAccount acc5 = acc3 as BusinessAccount;
                acc5.Loan(200.0);
                Console.WriteLine();
            }

            if (acc3 is SavingsAccount)
            {
                //SavingsAccount acc5 = (SavingsAccount)acc3
          
                SavingsAccount acc5 = acc3 as SavingsAccount;
                acc5.UptateBalance();
                Console.WriteLine();
            }

            acc.WithDraw(10.0);
            acc3.WithDraw(10.0);

            Console.WriteLine(acc.Balance);
            Console.WriteLine(acc3.Balance);

            Console.ReadKey();



        }
    }
}
