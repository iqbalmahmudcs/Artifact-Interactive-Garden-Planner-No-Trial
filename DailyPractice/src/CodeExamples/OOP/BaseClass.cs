using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    public class BaseClass
    {
        public string PublicProperty { get; set; }   //Accessable from everywhere.
        private string PrivateProperty { get; set; }   //Accessable only within this class.
        protected string ProtectedProperty { get; set; }   //Accessable in this class and derived class.
        internal string InternalProperty { get; set; }   //Accessable in the same assembly.
        protected internal string ProtectedInternalProperty { get; set; }   //Accessable in the same assembly or derived class.
        private protected string PrivateProtectedProperty { get; set; }   //Accessable within this class or derived class in the same assembly.


        public void DisplayProperties()
        {
            Console.WriteLine($"Public: {PublicProperty}");
            Console.WriteLine($"Private: {PrivateProperty}");
            Console.WriteLine($"Protected: {ProtectedProperty}");
            Console.WriteLine($"Internal: {InternalProperty}");
            Console.WriteLine($"Protected Internal: {ProtectedInternalProperty}");
            Console.WriteLine($"Private Protected: {PrivateProtectedProperty}");
        }



    }
}
