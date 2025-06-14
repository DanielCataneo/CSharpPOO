using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Exercício_de_Fixação_Cap._5
{
    internal class Conta_Bancária
    {
        public int NumeroDaConta { get; private set; }
        public string NomeDoTitular { get; set; }
        public double Saldo {  get; private set; }

        public Conta_Bancária(int numero, string nome)
        {
            NumeroDaConta = numero;
            NomeDoTitular = nome;   
        }

        public Conta_Bancária(int numero, string nome, double depositoinicial) : this(numero , nome)
        {
            Deposito(depositoinicial);
        }

        public void Deposito(double quantia)
        {
             
           Saldo += quantia ;
        }

        public void Saque(double saque)
        {
            Saldo -= saque;
            Saldo -= 5.0;
        }

        public override string ToString()
        {
            return "Número da Conta: " + NumeroDaConta.ToString() + " Nome do Titular: " + NomeDoTitular + ", Saldo = R$ " 
            + Saldo.ToString("F2", CultureInfo.InvariantCulture) ; 
        }
    }
}
