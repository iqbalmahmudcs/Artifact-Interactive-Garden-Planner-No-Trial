using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoreOnClasses
{
    public class Circle : Shape
    {
        public static int Count { get; private set; }

        public Circle()
        {
            Count++;
        }
        public double Radius {  get; set; }
        public override double CalculateArea()
        {
            return Math.PI * Radius * Radius;
        }
    }
}
