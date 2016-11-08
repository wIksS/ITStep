using Sorting.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting
{
    public class SelectionSorter : Sorter
    {
        public SelectionSorter(int[] array, ILogger logger)
            :base(array, logger)
        {
            this.SortType = SortType.Selection;
        }

        public override int[] Sort()
        {
            for (int i = 0; i < this.Array.Length; i++)
            {
                int min = this.Array[i];
                int minIndex = i;
                for (int j = i; j < this.Array.Length; j++)
                {
                    if (min > this.Array[j])
                    {
                        min = this.Array[j];
                        minIndex = j;
                    }
                }

                int temp = this.Array[i];
                this.Array[i] = min;
                this.Array[minIndex] = temp;
            }

            this.Logger.WriteLine("Sorted array successfuly at " + DateTime.Now.ToString());

            return this.Array;
        }
    }
}
