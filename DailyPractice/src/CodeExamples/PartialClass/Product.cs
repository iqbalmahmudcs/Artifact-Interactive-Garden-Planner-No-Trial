using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartialClass
{
    public partial class Product
    {
        public string Name { get; set; }

        public Product(string name, double price)
        {
            Name = name;
            Price = price;
        }

        public double CalculateDiscount(double percent)
        {
            return percent * 100;
        }
    }
}
