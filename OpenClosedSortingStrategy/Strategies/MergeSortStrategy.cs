using System;
using System.Collections.Generic;
using System.Text;

namespace OpenClosedSortingStrategy.Strategies
{
    public class MergeSortStrategy : ISortingStrategy
    {
        public List<T> Sort<T>(List<T> list)
        {
            Console.WriteLine("Merge sorting...");

            return list;
        }
    }
}
