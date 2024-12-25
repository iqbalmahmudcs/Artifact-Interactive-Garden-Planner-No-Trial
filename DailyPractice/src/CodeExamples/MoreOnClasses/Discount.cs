using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoreOnClasses
{
    public class Discount
    {
        public double DiscountAmount { get; set; }

        public virtual double GetAmount(double amount)
        {
            return DiscountAmount * amount / 100;
        }
    }
}
