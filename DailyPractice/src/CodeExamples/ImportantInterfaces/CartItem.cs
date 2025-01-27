using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImportantInterfaces
{
    public class CartItem : ICloneable
    {
        public Product Product { get; set; }
        public int Quantity { get; set; }

        public object Clone()
        {
            return new CartItem() { Product = Product, Quantity = Quantity };
        }

        public void IncreaseQuantity()
        {
            Quantity++;
        }

    }
}
