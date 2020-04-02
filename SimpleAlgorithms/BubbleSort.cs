using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleAlgorithms
{
    class BubbleSort
    {
        public void Search(int[] array)
        {
            for(int i = array.Length - 1; i > 0; i--)
                for(int j = 1; j <= i; j++)
                    if(array[j-1] > array[j])
                    {
                        var temp = array[j - 1];
                        array[j - 1] = array[j];
                        array[j] = temp;
                    }
        }
    }
}