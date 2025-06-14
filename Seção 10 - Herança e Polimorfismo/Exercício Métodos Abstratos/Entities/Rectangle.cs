using Exercício_Métodos_Abstratos.Entities.Enums;




namespace Exercício_Métodos_Abstratos.Entities
{
    class Rectangle : Shape
    {
        public  double Height { get; set; }
        public double Width { get; set; }



        public Rectangle(double height, double width , Color cor) : base(cor)
        {
            Height = height;
            Width = width;
        }

        public override double Area()
        {
            return Height * Width;
        }
    }
}
