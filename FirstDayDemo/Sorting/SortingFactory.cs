using Sorting.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting
{
    public class SortingFactory
    {
        public Sorter Create(SortType sortType, int[] array, ILogger logger)
        {
            if (sortType == SortType.Selection)
            {
                return new SelectionSorter(array, logger);
            }
            else if (sortType == SortType.Bubble)
            {
                return new BubbleSorter(array, logger);
            }

            return null;
        }
    }
}
