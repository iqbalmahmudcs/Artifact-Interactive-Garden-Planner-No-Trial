using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorWithOverloadedMethods
{
    public class Calculator
    {
        public int Addition(int x, int y) { return x + y; }
        public int Addition(int x, int y, int z) { return x + y + z; }
        public double Addition(double x, double y) { return x + y; }
        public int Multiplication(int x, int y) { return x * y; }
        public int Multiplication(int x, int y, int z) { return x * y * z; }
        public double Multiplication(double x, double y) { return x * y; }
    }
}
