using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    internal class Car : Machine
    {
        public override void Start()
        {
            Console.WriteLine("Car Started");
        }
    }
}
