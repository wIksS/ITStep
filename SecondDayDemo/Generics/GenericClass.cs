using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    public class GenericClass<T> where T : struct
    {
        public GenericClass(T genericProperty)
        {
            this.GenericProperty = genericProperty;
        }

        public T GenericProperty { get; set; }

        public override string ToString()
        {
            return GenericProperty.ToString();
        }
    }
}
