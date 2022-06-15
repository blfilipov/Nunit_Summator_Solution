using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Summator
{
    public static class Summator
    {
        public static long Sum(int[] arr)
        {
            long sum = arr[0];

            for (int i = 1; i < arr.Length; i++)
            {
                sum += arr [i];
            }

            return sum;
        }

    }
}
