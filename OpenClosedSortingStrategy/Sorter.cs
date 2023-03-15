using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace OpenClosedSortingStrategy
{
    class Sorter
    {
        private string strategy;

        public Sorter(string strategy)
        {
            this.strategy = strategy;
        }

        public List<T> Sort<T>(List<T> list)
        {
            if (strategy == "Merge")
            {
                //Merge sort
            }
            if (strategy == "Bubble")
            {
                // Bubble sort
            }

            return list;
        }
    }
}
