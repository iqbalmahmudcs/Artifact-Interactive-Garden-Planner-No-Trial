using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImportantInterfaces
{
    public class ShoppingCart : IEnumerable<CartItem>
    {
        private CartItem[] Items {  get; set; }
        private int index = 0;

        public ShoppingCart() 
        { 
            Items = new CartItem[100];
        }

        public void AddProduct(CartItem item)
        {
            Items[index++] = item;
        }

        public IEnumerator<CartItem> GetEnumerator()
        {
            return new CartEnumerator(Items, index);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
