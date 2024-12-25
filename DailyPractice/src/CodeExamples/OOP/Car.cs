using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    /*
        * Class: A blueprint for creating objects. It defines properties, methods, and events.
        * Object: An instance of a class.
     */
    public class Car  //This is a class
    {
        public string Brand {  get; set; }  //Properties
        public int Speed { get; set; }

        public void Drive()  //method
        {
            Console.WriteLine($"{Brand} is driving at {Speed} km/h.");
        }
    }
}
