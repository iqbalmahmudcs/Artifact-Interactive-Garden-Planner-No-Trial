using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IterfaceExample
{
    public interface IShape
    {
        double CalculateArea();
        double CalculatePerimeter();

        public double CalculateVolume()
        {
            return 500;
        }
    }
}  