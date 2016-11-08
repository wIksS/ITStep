using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericList
{
    class Program
    {
        static void Main(string[] args)
        {
            GenericList<string> list = new GenericList<string>();

            list.OnResizeEvent += (int newSize) =>
            {
                Console.WriteLine("Array resized! New size is : {0}", newSize);
            };

            list.OnAddEvent += OnAddEventHandler;

            list.Add("pesho");
            list.Add("gosho");
            list.Add("stamat");
            list.Add("stamat");

            list[2] = "Changed from index";

            foreach (var item in list)
            {
                Console.Write(item + "  ");
            }

            Console.WriteLine("\nAfter removed \"Changed from index\" element");

            list.Remove("Changed from index");
            list.Add("After removed");
            foreach (var item in list)
            {
                Console.Write(item + " ");
            }

            Console.WriteLine();
        }

        private static void OnAddEventHandler()
        {
            Console.WriteLine("Element added!");
        }
    }
}
