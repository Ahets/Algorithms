using System.Collections.Generic;
using System.Linq;

namespace SortAlgorithms.Core
{
    public class ListSort : ISortAlgorithm
    {
        public int[] Sort(int[] arr)
        {
            var list = new List<int>();
            list.AddRange(arr);
            list.Sort();
            return list.ToArray();
        }
    }
}
