using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exercício_de_Fixação.Entities.Enums;

namespace Exercício_de_Fixação.Entities
{
    internal class Product
    {
        public string Name { get; set; }

        public double Price { get; set; }

        
        

        public Product(string name, double price)
        {
            Name = name;
            Price = price;
           
        }

        

    }
}
