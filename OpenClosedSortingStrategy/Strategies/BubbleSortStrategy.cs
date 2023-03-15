using System;
using System.Collections.Generic;
using System.Text;

namespace OpenClosedSortingStrategy.Strategies
{
    public class BubbleSortStrategy : ISortingStrategy
    {
        public List<T> Sort<T>(List<T> list)
        {
            Console.WriteLine("Bubble sorting...");

            return list;
        }
    }
}
