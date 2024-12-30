using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExploreAccessModifiersWithInheritance
{
    public class Car :Vehicle
    {
        public void SetFuel(string fuel)
        {
            Fuel = fuel;
        }
        public void DisplayDetails()
        {
            Console.WriteLine($"Type: {Type}");
            Console.WriteLine($"Fuel: {Fuel}");
        }
    }
}
