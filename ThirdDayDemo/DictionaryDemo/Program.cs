using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictionaryDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> students = new Dictionary<int, string>();

            students.Add(6, "Gosho");
            students.Add(5, "Eli");
            students.Add(7, "Stamat");
            students[7] = "pesho";

            Console.WriteLine(students[5]);

            foreach (KeyValuePair<int,string> item in students)
            {
                Console.WriteLine("Key : {0} ---> {1}",item.Key, item.Value);
            }

            if (students.ContainsKey(27))
            {
                Console.WriteLine(students[27]);
            }
        }
    }
}
