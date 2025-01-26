using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InportantInterfaces
{
    public class CartEnumerator : IEnumerable<CartItem>
    {
        public CartItem Current => throw new NotImplementedException();

        //object IEnumerator.Current => throw new NotImplementedException();

        public void Dispose() 
        {
            throw new NotImplementedException();
        }

        public IEnumerator<CartItem> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        public bool MoveNext()
        {
            throw new NotImplementedException();
        }
        public void Reset() 
        {
            throw new NotImplementedException(); 
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
