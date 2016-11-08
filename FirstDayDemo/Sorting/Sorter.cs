using Sorting.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting
{
    public abstract class Sorter
    {
        public Sorter(int[] array, ILogger logger)
        {
            Console.WriteLine("From sorter");
            this.Array = array;
            this.Logger = logger;
        }

        protected int[] Array { get; set; }

        protected ILogger Logger { get; set; }

        public abstract int[] Sort();

        public SortType SortType { get; protected set; }
    }
}
