using System;
using System.Collections.Generic;

namespace OpenClosedSortingStrategy
{
    class Program
    {
        static void Main(string[] args)
        {
            string strategy = Console.ReadLine();

            Sorter sorter = new Sorter(strategy);

            sorter.Sort(new List<int>() { 1, 2, 3 });
        }
    }
}
