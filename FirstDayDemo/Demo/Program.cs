using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[5] { 1, -2, 3, -4, 5 };
            int[] secondArray = array.Select(x => x).ToArray();
            secondArray[0] = 100;
            Console.WriteLine(array[0]);
            Console.WriteLine(secondArray[0]);

        }
    }
}
