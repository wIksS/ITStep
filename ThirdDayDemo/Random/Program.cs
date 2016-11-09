using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            for (int i = 0; i < 100; i++)
            {
                double number = Math.Round(random.NextDouble() * 1000,2);

                Console.WriteLine(number);
            }
        }
    }
}
