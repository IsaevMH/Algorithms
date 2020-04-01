using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleAlgorithms
{
    public class LinearSearch
    {
        public int Search<T>(T[] array, T targetValue)
        {
            for(int i = 0; i < array.Length; i++)
            {
                if (array[i].Equals(targetValue))
                    return i;
            }
            return -1;
        }
    }
}
