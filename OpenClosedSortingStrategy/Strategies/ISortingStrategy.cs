using System;
using System.Collections.Generic;
using System.Text;

namespace OpenClosedSortingStrategy.Strategies
{
    public interface ISortingStrategy
    {
        List<T> Sort<T>(List<T> lsit);
    }
}
