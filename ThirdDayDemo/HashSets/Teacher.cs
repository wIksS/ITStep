using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashSets
{
    public class Teacher : Human
    {
        public Teacher(string name)
            : base(name)
        {
            this.Students = new List<Student>();
        }

        public List<Student> Students{ get; set; }
    }
}
