using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events
{
    class Program
    {
        static void Main(string[] args)
        {
            ListTracker tracker = new ListTracker();
            tracker.OnChange += () =>
            {
                Console.WriteLine("Test");
            };

            tracker.Add(5);

            //Console.WriteLine(tracker.List[0]);
        }
    }
}
