using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleAlgorithms
{
    public class BinarySearch : IComparable
    {
        public int CompareTo(object obj)
        {
            throw new NotImplementedException();
        }

        public int Search<T>(int[] array, int targetValue)
        {
            int left = 0;
            int right = array.Length - 1;
            while(left < right)
            {
                var middle = (right + left) / 2;
                if (targetValue <= array[middle])
                    right = middle;
                else
                    left = middle+1;
            }
            if (targetValue == array[right])
                return right;
            return -1;
        }
    }
}
