using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public abstract class Person
    {
        internal string FirstName { get; set; }
        internal string LasttName { get; set; }
        internal DateTime DateOfBirth { get; set; }

        public abstract void DisplayDetails();


    }
}
