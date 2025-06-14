using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Exercício_de_Fixação_Static
{
    internal class ConversorDeMoeda
    {

        

        public static double Multiplicador(double Vdolar, double Quantia)
        {
            double total = Vdolar * Quantia;
            return total + total * 0.06;

        }
    }
}
