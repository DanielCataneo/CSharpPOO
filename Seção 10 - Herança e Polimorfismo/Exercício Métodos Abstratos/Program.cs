using Exercício_Métodos_Abstratos.Entities.Enums;
using System;
using System.Collections.Generic;
using Exercício_Métodos_Abstratos.Entities;
using System.Globalization;

namespace Exercício_Métodos_Abstratos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Shape> shapes = new List<Shape>();

            Console.Write("Enter the number of shapes: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine("Shape #" + i + " data:");
                
                Console.Write("Color (Black/Blue/Red) :");
                Color colour;
                Enum.TryParse(Console.ReadLine(), out colour); 

                Console.Write("Rectangle or Circle (r/c) :");
                char opcao = char.Parse(Console.ReadLine().ToUpper());




                switch (opcao)
                {
                    case 'R':
                        {

                            Console.Write("Width: ");
                            double width = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                            Console.Write("Height: ");
                            double height = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                            shapes.Add(new Rectangle(height, width, colour));
                            break;
                        }

                    case 'C':
                        {
                            Console.Write("Radius: ");
                            double radius = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                            shapes.Add(new Circle(radius, colour));
                            break;
                        }
                }
                
            }
                
                Console.WriteLine();
                Console.WriteLine("SHAPE AREAS");
                
                foreach(Shape shape in shapes)
                {
                    Console.WriteLine(shape.Area().ToString("F2" , CultureInfo.InvariantCulture));
                }

                Console.ReadKey();






            
        }
    }
}
