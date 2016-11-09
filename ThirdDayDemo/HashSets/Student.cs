using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashSets
{
    public class Student : Human
    {
        public Student(int number, string name)
            :base(name)
        {
            this.Number = number;
        }

        public int Number { get; set; }

        public Teacher Teacher { get; set; }
    }
}
