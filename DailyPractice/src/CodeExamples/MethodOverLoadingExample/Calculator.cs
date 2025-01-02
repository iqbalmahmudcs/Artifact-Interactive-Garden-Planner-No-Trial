using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverLoadingExample
{
    public class Calculator
    {
        public int Calculation(int a, int b) { return a + b; }
        
        //method overloading (Number of parameters)
        public int Calculation(int a, int b, int c) { return a + b + c; }
        //methid overloading different types of parameter
        public double Calculation(double a, double b) { return a + b; }
    }
}
