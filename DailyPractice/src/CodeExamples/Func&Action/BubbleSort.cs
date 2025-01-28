using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace FunctionAction
{
    public class BubbleSort<T> 
    {
        //public delegate bool Compare(T a, T b);
        public T[] Sort(T[] arr, Func<T , T, bool> compare) 
        {
            var temp = default(T);
            for (int i = 0; i <= arr.Length - 2; i++)
            {
                for (int j = 0; j <= arr.Length - 2; j++)
                {
                    if (compare(arr[j], arr[j+1]))
                    {
                        temp = arr[j + 1];
                        arr[j + 1] = arr[j];
                        arr[j] = temp;
                    }
                }
            }
            return arr;
        }
    }
}
        