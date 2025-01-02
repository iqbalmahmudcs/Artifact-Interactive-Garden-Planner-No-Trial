using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverLoadingExample
{
    public class Printer
    {
        public string Print(string firstName) { return ($"Name: {firstName}"); }
        public string Print(string firstName, string lastName)
        {
            return ($"First name: {firstName} Last Name:{lastName}");
        }
        public string Print( string firstName, int age)
        {
            return ($"Name: {firstName} Age: {age}");
        }

    }
}
