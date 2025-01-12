using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParameterModifiers
{
    public class Demo
    {
        public static double Average(int x, int y, params int[] a)
        {
            int sum = 0;
            foreach (int i in a)
            {
                sum += i;
            }
            return sum / a.Length;
        }

        public static void Test1(ref int x)
        {
            x = 5;
        }
        public static void Test2(in int x)
        {
            //x = 5;
        }
        public static void Test3(out int x)
        {
            x = 5;
        }


    }
}
