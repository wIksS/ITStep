using HashSets;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortedCollections
{
    class StudentsComparer : IComparer<Char>
    {
        public int Compare(Char x, Char y)
        {
            if (x < y)
            {
                return 1;
            }
            else if (x == y)
            {
                return 0;
            }
            else
            {
                return -1;
            }
        }
    }
}
