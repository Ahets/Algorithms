using System;
using SortAlgorithms.Core;

namespace SortAlgorithms.App
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr = new int[] { 4, 5, 1, 3, 2, 9, 7, 6, 8 };

            Console.WriteLine(string.Join(" ", arr));

            var algorithm = new ListSort();
            

            Console.WriteLine(string.Join(" ", algorithm.Sort(arr)));
            Console.ReadKey();
        }
    }
}
