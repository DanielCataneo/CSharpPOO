using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exercício_de_Fixação.Entities.Enums;

namespace Exercício_de_Fixação.Entities
{
    internal class Client
    {
        public string Name { get; set; }
        public string Email { get; set; }

        public DateTime BirthDate { get; set; }



        Client() { }

        public Client(string name, string email, DateTime birthDate)
        {
            Name = name;
            Email = email;
            BirthDate = birthDate;
        }


        public override string ToString()
        {
            return Name
                + ", ("
                + BirthDate.ToString("dd/MM/yyyy")
                + ") - "
                + Email;
        }
    }
}
