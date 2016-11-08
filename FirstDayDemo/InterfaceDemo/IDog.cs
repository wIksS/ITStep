using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceDemo
{
    public interface IDog
    {
        int Legs { get; set; }

        int Tail { get; set; }

        void Bark();

        void Eat();
    }
}
