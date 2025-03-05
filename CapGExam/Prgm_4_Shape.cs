using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapGExam
{
    abstract class Prgm_4_Shape
    {
        public abstract double Area();


    }
    class Circle : Prgm_4_Shape
    { 
        public double Radius { get; set; }
        public Circle(double radius)
        {
            Radius = radius;
        }
        public override double Area() 
        {
            return Math.PI * Radius * Radius;
        }
    }
    class Rectangle : Prgm_4_Shape
    {
        public double Length { get; set; }
        public double Width { get; set; }
        public Rectangle(double length, double width)
        {
            Length = length;
            Width = width;
        }
        public override double Area()
        {
            return Length * Width;
        }
    }

}
