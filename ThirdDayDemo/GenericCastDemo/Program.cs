using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HashSets;

namespace GenericCastDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Teacher teacher = new Teacher("pesho");
            Teacher teacher2 = new Teacher("pesho");

            Console.WriteLine(teacher.GetHashCode());
            Console.WriteLine(teacher2.GetHashCode());
            Cast(teacher);
        }

        private static void Cast<T>(T obj)
        {
            Human human = obj as Human;

            if (human != null)
            {
                Console.WriteLine(human.Name);
            }
        }
    }
}
