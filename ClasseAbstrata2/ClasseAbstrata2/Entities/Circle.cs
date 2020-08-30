
using ClasseAbstrata2.Entities.Enums;
using System.Text.RegularExpressions;
using System;

namespace ClasseAbstrata2.Entities
{
    class Circle : Shape
    {
        public double Radius { get; set; }

        public Circle(double radius, Color color) : base (color) // chamar construtor da classe Shape
        {
            Radius = radius;
        }

        public override double area()
        {
            return Math.PI * Radius * Radius;
        }
    }
}
