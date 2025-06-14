using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.Security.Cryptography;

namespace Ex_3___Exercícios_de_Fixação
{
    internal class Aluno
    {
        public string Nome;
        public double NotaA;
        public double NotaB;
        public double NotaC;

        public double MediaNota()
        {
            return ( NotaA + NotaB + NotaC );
        }




    }
}
