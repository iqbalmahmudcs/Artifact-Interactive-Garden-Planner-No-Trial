using Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    public class Laptop : Electronics
    {
        public Laptop(double energyConsumption, double price) : base(energyConsumption, price)
        {
            Price = 0;
        }
    }
}
