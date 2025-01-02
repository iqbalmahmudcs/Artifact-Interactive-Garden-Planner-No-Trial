using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaCalculatorWithOverloadedMethods
{
    public class AreaCalculator
    {
        public double CalculateArea(double radius) { return Math.PI * radius * radius; }
        public int CalculateArea(int  lenth, int width) { return lenth * width; }
        public double CalculateArea(double  baze, double height) { return 0.5 * baze * height; }
    }
}
