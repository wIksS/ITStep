using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashSets
{
    public class StudentsComparer : IEqualityComparer<Student>
    {
        public bool Equals(Student x, Student y)
        {
            if (x.Number == y.Number)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public int GetHashCode(Student obj)
        {
            return obj.Number.GetHashCode();
        }
    }
}
