using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Ex_2___Exercícios_de_Fixação
{
    internal class Funcionario
    {
        public string Nome;
        public double SalarioBruto;
        public double Imposto;

        public double SalarioLiquido()
        {
            return SalarioBruto - Imposto;
        }

        public void AumentarSalario(double porc)
        {
            SalarioBruto = SalarioBruto + (SalarioBruto * porc / 100.0);
        }
        public override string ToString()
        {
            return Nome + ", Salário $" + SalarioLiquido().ToString("f2" , CultureInfo.InvariantCulture) ;
        }
        


        
    }
}
