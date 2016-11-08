using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    class Program
    {
        delegate int PerformCalculation(int x, int y);

        static void Main(string[] args)
        {
            PerformCalculation functionVariable = Substract;
            functionVariable += Multiply;
            functionVariable += Substract;
            functionVariable -= Multiply;
            Console.WriteLine(functionVariable(5, 6));
        }

        public static int Substract(int x, int y)
        {
            Console.WriteLine("In substract");
            return x - y;
        }

        public static int Multiply(int x, int y)
        {
            
            Console.WriteLine("In multiply");
            return x * y;
        }
    }
}
