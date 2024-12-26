using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    public class DerivedClass : BaseClass
    {
        public void DisplayInheritedProperties()
        {
            Console.WriteLine($"Public: {PublicProperty}");
            // Console.WriteLine($"Private: {PrivateProperty}"); // Not accessible
            Console.WriteLine($"Protected: {ProtectedProperty}");
            Console.WriteLine($"Internal: {InternalProperty}");
            Console.WriteLine($"Protected Internal: {ProtectedInternalProperty}");
            // Console.WriteLine($"Private Protected: {PrivateProtectedProperty}"); // Accessible only within the same assembly
        }
    }
}
