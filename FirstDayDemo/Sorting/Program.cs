using Sorting.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting
{

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(SortType.Selection);
            Console.WriteLine("Enter array!");            

            int[] array = Console.ReadLine()
                .Split()
                .Select(x => int.Parse(x)).ToArray();

            SortType sortType = SortType.Selection;
            Console.WriteLine("Enter sorting type");
            string input = Console.ReadLine();

            switch (input.ToLower())
            {
                case "selection": sortType = SortType.Selection;
                    break;
                case "bubble":
                    sortType = SortType.Bubble;
                    break;
                default:
                    break;
            }

            ILogger logger = new ConsoleLogger();
            SortingFactory sortingFactory = new SortingFactory();
            Sorter sorter = sortingFactory.Create(sortType,array,logger);            

            int[] sortedArray = sorter.Sort();

            logger.WriteLine(String.Join(",",sortedArray));
        }
    }
}
