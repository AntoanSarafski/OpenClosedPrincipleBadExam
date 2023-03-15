﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using OpenClosedSortingStrategy.Strategies;
using System.Reflection;

namespace OpenClosedSortingStrategy
{
    class Sorter
    {

        private ISortingStrategy sortingStrategy;

        public Sorter(string strategy)
        {
            Type type = Assembly.GetExecutingAssembly()
                .GetTypes()
                .Where(t => typeof(ISortingStrategy)
                .IsAssignableFrom(t))
                .First();

            sortingStrategy = (ISortingStrategy)Activator.CreateInstance(type);


        }

        public List<T> Sort<T>(List<T> list)
        {
            list = sortingStrategy.Sort(list);

            return list;
        }
    }
}
