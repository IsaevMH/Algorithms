using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleAlgorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            //Алгоритм линейненого поиска
            LinearSearch ls = new LinearSearch();
            Console.WriteLine(ls.Search<int>(new int[] { 1, 3, 2, 5}, 5).ToString());
            Console.WriteLine(ls.Search<double>(new double[] { 2.1, 4.3, 1.2, 6.6 }, 1.2));
            Console.WriteLine(ls.Search<string>(new string[] { "one", "two", "five" }, "five"));

            //Алгоритм бинарного поиска

            Console.ReadKey();
        }
    }
}
