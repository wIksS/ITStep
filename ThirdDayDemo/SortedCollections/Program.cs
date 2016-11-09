using System;
using System.Collections.Generic;
//using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortedCollections
{
    class Program
    {
        static void Main(string[] args)
        {
            StudentsComparer comparer = new StudentsComparer();
            SortedSet<char> alphabet = new SortedSet<char>(comparer);

            alphabet.Add('b');
            alphabet.Add('c');
            alphabet.Add('a');
            alphabet.Add('a');

            foreach (var item in alphabet)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("Sorted dictionary : ");

            SortedDictionary<char, string> alphabetDictionary = new SortedDictionary<char, string>(comparer);
            alphabetDictionary.Add('c', "car");
            alphabetDictionary.Add('b', "bold");
            alphabetDictionary.Add('z', "z-index");
            alphabetDictionary.Add('t', "text");
            
            foreach (var item in alphabetDictionary)
            {
                Console.WriteLine("{0} --> {1}", item.Key, item.Value);
            }
        }
    }
}
