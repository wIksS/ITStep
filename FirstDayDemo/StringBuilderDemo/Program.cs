using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringBuilderDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder text = new StringBuilder();

            for (int i = 0; i < 1000; i++)
            {
                text.AppendLine("pesho" + i);
            }

            Console.WriteLine(text);
        }
    }
}
