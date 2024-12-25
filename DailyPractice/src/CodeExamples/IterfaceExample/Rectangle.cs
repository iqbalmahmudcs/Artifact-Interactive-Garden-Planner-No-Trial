using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IterfaceExample
{
    public class Rectangle : DrawingItem , IShape, IMoveable
    {
        public double CalculateArea()
        {
            return 100;
        }
        public double CalculatePerimeter() 
        { 
            return 200;
        }

        public void Move()
        {

        }
        public double CalculateVolume()
        {
            return 500;
        }
    }
}
