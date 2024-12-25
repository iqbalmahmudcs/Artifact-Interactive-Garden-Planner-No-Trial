using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    public class Shape
    {
        /*Polymorphism
        * Ability to process objects differently based on their data type or class.
        * Achieved through:
            * method overriding (virtual and override) and 
            * method overloading.
         */
        public virtual void Draw() => Console.WriteLine("Drawing a shape.");
        public void Draw(string color) => Console.WriteLine($"Drawing a shape with color {color}.");  //Method Overloading
        public void Draw(int thickness) => Console.WriteLine($"Drawing a shape with line thickness {thickness}.");  //Method Overloading

    }
}
