using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exercício_Métodos_Abstratos.Entities;
using Exercício_Métodos_Abstratos.Entities.Enums;

namespace Exercício_Métodos_Abstratos.Entities
{
    // Notação UML - Itálico
    abstract class Shape
    {
        public Color Color { get; set; }

        protected Shape(Color color) 
        { 
            Color = color;
        }

        public abstract double Area();
    }
}
