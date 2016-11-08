using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace GenericPrint
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new int[5] { 1, 2, 3, 4, 5 };
            PrintCollection(list);
        }

        private static void PrintCollection(IEnumerable<int> list)
        {
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }
    }
}
