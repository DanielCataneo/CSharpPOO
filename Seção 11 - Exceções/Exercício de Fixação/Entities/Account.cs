using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exercício_de_Fixação.Entities.Exceptions;
using System.Globalization;

namespace Exercício_de_Fixação.Entities
{
    internal class Account
    {
        public  int  Number { get; set; }
        public string Holder { get; set; }
        public double Balance { get; set; }
        public double WithdrawLimit { get; set; }

        public Account() { }

        public Account(int number, string holder, double balance, double withdrawLimit)
        {
            Number = number;
            Holder = holder;
            Balance = balance;
            WithdrawLimit = withdrawLimit;
        }

        public void Deposit(double amount)
        {
            Balance += amount;
        }

        public void Withdraw(double amount)
        {
            if (amount > WithdrawLimit)
            {
                throw new DomainException("The amount exceeds withdraw limit ");
            }
            
            if ( amount > Balance || amount > WithdrawLimit) 
            {
                throw new DomainException("Not enough Balance ");
            }

            Balance -= amount;

        }

        public override string ToString()
        {
            return "Number: " + Number + ", " + "Name: " + Holder + ", " + Balance.ToString("f2" , CultureInfo.InvariantCulture);
        }


    }
}
