using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImportantInterfaces
{
    public class CartEnumerator : IEnumerator<CartItem>
    {
        private CartItem[] _cartItems;
        private int _lenth;
        
        public CartItem Current
        {
            get { return _cartItems[_index]; }
        }

        object IEnumerator.Current
        {
            get
            {
                return Current;
            }
        }

        private int _index;

        public CartEnumerator(CartItem[] cartItems, int lenth)
        {
            _cartItems = cartItems;
            _index = -1;
            _lenth = lenth;
        }

        public void Dispose()
        {
            _cartItems = null;
        }

        public bool MoveNext()
        {
            _index++;
            return _index < _lenth;
        }

        public void Reset()
        {
            _index = -1;
        }
    }
}
