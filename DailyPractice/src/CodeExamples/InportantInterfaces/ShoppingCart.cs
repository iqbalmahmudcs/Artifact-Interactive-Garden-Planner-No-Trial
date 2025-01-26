using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InportantInterfaces
{
    public class ShoppingCart : IEnumerable<CartItem>
    {
        private List<CartItem> Items {  get; set; }

        public void AddProduct(CartItem item)
        {
            Items.Add(item);
        }

        public IEnumerator<CartItem> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
