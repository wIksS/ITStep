using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceDemo
{
    public class Dog :IDog 
    {
        public int Legs
        {
            get
            {
                return 4 - 1;
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        public int Tail
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        public void Bark()
        {
            Console.WriteLine("Bark");
        }

        public void Eat()
        {
            throw new NotImplementedException();
        }
    }
}
