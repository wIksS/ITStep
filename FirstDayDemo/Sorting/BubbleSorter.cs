using Sorting.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting
{
    public class BubbleSorter : Sorter
    {
        public BubbleSorter(int[] array, ILogger logger)
            : base(array, logger)
        {
            this.SortType = SortType.Bubble;
        }

        public override int[] Sort()
        {
            throw new NotImplementedException();
        }
    }
}
