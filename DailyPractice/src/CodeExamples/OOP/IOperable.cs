using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    /*
     * Key Points:
        * Naming Convention: By convention, interface names in C# start with the letter I
        * Default Implementation (C# 8.0+): Starting from C# 8.0, interfaces can have default method implementations using the default keyword, but this is an advanced feature.
        * Multiple Interfaces: A class can implement 
            * multiple interfaces, enabling a more modular and flexible design.
     */
    public interface IOperable
    {
        void Start();  //Interface method
    }
}
