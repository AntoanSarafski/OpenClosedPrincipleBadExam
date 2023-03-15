using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using OpenClosedSortingStrategy.Strategies;

namespace OpenClosedSortingStrategy
{
    class Sorter
    {

        private ISortingStrategy sortingStrategy;

        public Sorter(string strategy)
        {
            if (strategy == "Bubble")
            {
                sortingStrategy = new BubbleSortStrategy();
            }
            if (strategy == "Merge")
            {
                sortingStrategy = new MergeSortStrategy();
            }
        }

        public List<T> Sort<T>(List<T> list)
        {
            list = sortingStrategy.Sort(list);

            return list;
        }
    }
}
