using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_1___Exercícios_de_Fixação
{
    internal class Retangulo
    {
        public double Largura;
        public double Altura;

        public double Perimetro()
        {
            return (Altura * 2) + (Largura * 2);
        }

        public double Area()
        {
            return Altura * Largura;
        }
    
        public double Diagonal()
        {
            return Math.Sqrt(Altura * Altura + Largura * Largura);
        }
    }
}
