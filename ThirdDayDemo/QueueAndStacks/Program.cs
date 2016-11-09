using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueueAndStacks
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<int> queue = new Queue<int>();

            queue.Enqueue(5);
            queue.Enqueue(6);
            queue.Enqueue(7);

            while (queue.Count > 0)
            {
                int queueElement = queue.Dequeue();
                Console.WriteLine(queueElement);
            }

            Console.WriteLine("-------- Stack -------");
            Stack<int> stack = new Stack<int>();
            stack.Push(5);
            stack.Push(6);
            stack.Push(7);
            stack.Push(8);
            stack.Push(9);
            stack.Push(10);

            while (stack.Count > 0)
            {
                var stackElement = stack.Pop();
                Console.WriteLine(stackElement);
            }

            LinkedList<int> linkedList = new LinkedList<int>();

            linkedList.AddFirst(5);
            LinkedListNode<int> element = linkedList.First;
        }
    }
}
