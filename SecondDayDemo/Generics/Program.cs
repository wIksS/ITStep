using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Events;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {          
            GenericClass<int> genericClass = new GenericClass<int>(5);

            Console.WriteLine(genericClass);

            //PrintObject("Stamat");
        }

        private static T PrintObject<T>(T name)
        {
            Console.WriteLine("Your object's toString is : " + name.ToString());

            return name;
        }
    }
}
