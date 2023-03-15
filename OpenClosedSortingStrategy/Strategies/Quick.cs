using System;
using System.Collections.Generic;
using System.Text;

namespace OpenClosedSortingStrategy.Strategies
{
    public class QuickSortStrategy : ISortingStrategy
    {
        public List<T> Sort<T>(List<T> list)
        {
            Console.WriteLine("Quick sorting...");

            return list;
        }
    }
}
