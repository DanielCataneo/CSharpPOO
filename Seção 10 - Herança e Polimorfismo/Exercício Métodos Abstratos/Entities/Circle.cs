using Exercício_Métodos_Abstratos.Entities.Enums;
using System;

namespace Exercício_Métodos_Abstratos.Entities
{
     class Circle : Shape
    {
        public double Radius { get; set; }

        public Circle(double radius , Color cor) : base (cor)
        {
            Radius = radius;
        }

        public override double Area()
        {
            return Math.PI * Math.Pow(Radius , 2);
        }
    }
}
