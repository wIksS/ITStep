using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondDayDemo
{
    class Program
    {
        public delegate void HelloDelegate(string name);

        static void Main(string[] args)
        {
            Func<string, int> helloDelegate = Hello;
            helloDelegate("Gosho");
        }

        private static int Hello(string name)
        {

            Console.WriteLine(name);
            return 0;
        }
    }
}
