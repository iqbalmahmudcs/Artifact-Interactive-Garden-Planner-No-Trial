using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    /*Polymorphism
        * Ability to process objects differently based on their data type or class.
        * Achieved through:
            * method overriding (virtual and override) and 
            * method overloading.
     */
    
    public class Circle : Shape
    {
        public override void Draw() => Console.WriteLine("Drawing a circle.");

        // Overloading the Draw method of Shape in Circle
        public void Draw(string color, double radius)
        {
            Console.WriteLine($"Drawing a circle with color {color} and radius {radius}.");
        }
    }
}
