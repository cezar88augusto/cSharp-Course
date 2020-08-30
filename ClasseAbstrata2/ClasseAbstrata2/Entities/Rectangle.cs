
using ClasseAbstrata2.Entities.Enums;

namespace ClasseAbstrata2.Entities
{
    class Rectangle : Shape // Inicialmente vai dar erro, Deve-se implementar o método override.
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public Rectangle(double width, double height, Color color) : base(color)
        {
            Width = width;
            Height = height;
        }
        public override double area()
        {
            return Width * Height;
        }
    }
}
