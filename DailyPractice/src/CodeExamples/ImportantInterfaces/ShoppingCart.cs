using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImportantInterfaces
{
    public class ShoppingCart : ICollection<CartItem>, IEnumerable<CartItem>
    {
        private CartItem[] Items {  get; set; }

        public int Count
        {
            get
            {
                return index; 
            }
        }

        public bool IsReadOnly
        {
            get 
            {
                return true; 
            }
        }

        private int index = 0;

        public ShoppingCart() 
        { 
            Items = new CartItem[100];
        }

#region IEnumerable

        public IEnumerator<CartItem> GetEnumerator()
        {
            return new CartEnumerator(Items, index);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

#endregion

        public void Add(CartItem item)
        {
            Items[index++] = item;
        }

        public void Clear()
        {
            Items = new CartItem[100];
            index = 0;
        }

        public bool Contains(CartItem item)
        {
            foreach(CartItem x in Items)
            {
                if(x == item) return true;
            }
            return false;
        }

        public void CopyTo(CartItem[] array, int arrayIndex)
        {
            for (int i = 0; i < index; i++)
            {
                array[arrayIndex++] = Items[i];
            }
        }

        public bool Remove(CartItem item)
        {
            for (int i = 0; i < Items.Length; i++)
            {
                if (Items[i] == item) 
                    Items[i] = null;
                    return true;
            }
            return false; 
        }
    }
}
