using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Instrumentation;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_de_Fixação___Vetores
{
    internal class Hospede
    {
        public string Nome { get; set; }
        public string Email { get; set; }

        public Hospede(string nome, string email)
        {
            Nome = nome;
            Email = email;
        }

        public override string ToString()
        {
            return Nome + ", " + Email;
        }
    }
}
