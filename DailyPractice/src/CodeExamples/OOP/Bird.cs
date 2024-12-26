using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    public class Bird : Animal
    {
        internal void DisplayHabitat()
        {
            Console.WriteLine($"Bird's Habit is: {Habitat}");
        }

        internal void SetHabitat(string habitat)
        {
            this.Habitat = habitat;
        }
    }
}
