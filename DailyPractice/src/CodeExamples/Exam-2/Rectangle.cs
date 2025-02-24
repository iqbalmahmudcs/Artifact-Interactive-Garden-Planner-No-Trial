using System;
using System.Collections.Generic;
using System.Formats.Asn1;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_2
{
    public struct Rectangle
    {
        private double _width;
        private double _height;

        public Rectangle(double width, double height)
        {
            _width = width;
            _height = height;
        }

        public readonly double CalculateArea()
        {
            return _width * _height;
        }

        public readonly void Display()
        {
            Console.WriteLine($"Width {_width}");
            Console.WriteLine($"Height: {_height}");
            Console.WriteLine($"Area of the Rectangle is: {CalculateArea()}");
        }
    }
}
