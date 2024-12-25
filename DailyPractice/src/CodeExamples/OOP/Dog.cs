using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    /*
     * Inheritance
        * A mechanism where one class (child) can inherit from another (parent).
        * Use the : symbol to specify inheritance.
     */

    //This is a child class of Animal
    public class Dog : Animal
    {
        public void Bark() => Console.WriteLine("The Dog is Barking...");
    }
}
