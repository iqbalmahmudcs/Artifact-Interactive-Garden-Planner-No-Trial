using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExploreAccessModifiersWithInheritance
{
    public class Vehicle
    {
        public string Type { get; set; }
        protected string Fuel { get; set; }
        private int Milage { get; set; }
    }
}
