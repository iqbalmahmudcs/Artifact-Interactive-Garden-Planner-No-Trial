using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoreOnClasses
{
    public class RestictedDiscount : Discount
    {
        public sealed override double GetAmount(double amount)
        {
            double discountedAmount = DiscountAmount * amount / 100;
            if (discountedAmount > amount / 2)
            {
                return amount / 2;
            }
            else
                return discountedAmount;
        }
    }
}
