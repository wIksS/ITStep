using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordsCounter
{
    class Program
    {
        static void Main(string[] args)
        {
            IWordsCounter wordsCounter = new WordsCounter();
            string input = Console.ReadLine();

            Dictionary<string, int> words = wordsCounter.Count(input);

            foreach (var item in words)
            {
                Console.WriteLine("{0} --> {1}", item.Key, item.Value);
            }

            Console.WriteLine();

            var sortedDict = words.ToList().OrderByDescending(x => x.Value).ToDictionary(x => new KeyValuePair<string, int>(x.Key,x.Value));

            foreach (var item in sortedDict)
            {
                Console.WriteLine("{0} --> {1}", item.Key, item.Value);
            }
        }
    }
}
