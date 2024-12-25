using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    /*
     * Abstraction
     * Hiding implementation details and showing only the essential features of an object.
     * Achieved using 
        * abstract classes or 
        * interfaces.
     */
    public class Bicycle : Vehicle, IOperable 
    {
        public override void Move() => Console.WriteLine("Bicycle is moving.");

        public void Start()
        {
            Console.WriteLine("Bicycle is starting");
        }
    }
}
