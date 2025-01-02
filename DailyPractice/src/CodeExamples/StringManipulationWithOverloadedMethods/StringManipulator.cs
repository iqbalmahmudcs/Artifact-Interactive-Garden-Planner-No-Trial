using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringManipulationWithOverloadedMethods
{
    public class StringManipulator
    {
        public string StringManipulate(string inputString) { return new string(inputString.Reverse().ToArray()); }
        public string StringManipulate(string firstName, string lastName) { return $" {firstName + " " + lastName}"; }
        public int GateLenth(string inputString) { return inputString.Length; }
        public int StringManipulate(string inputString, char inputCharacter) { return inputString.Count(c => c == inputCharacter); }
    }
}
