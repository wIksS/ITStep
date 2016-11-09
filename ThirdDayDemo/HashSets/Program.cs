using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashSets
{
    class Program
    {
        static void Main(string[] args)
        {
            Teacher teacher = new Teacher("Stamat");
            IEqualityComparer<Student> comparer = new StudentsComparer();

            HashSet<Student> studentNumbers = new HashSet<Student>(comparer);

            while (true)
            {
                string line = Console.ReadLine();
                if (line == "-1")
                {
                    break;
                }

                string[] splitted = line.Split();
                Student student = new Student(int.Parse(splitted[1]), splitted[0]);

                if (studentNumbers.Contains(student))
                {
                    Console.WriteLine("Try again! Student is already added");
                }
                else
                {
                    studentNumbers.Add(student);
                    teacher.Students.Add(student);
                }

                Console.WriteLine("Student name is: " + student.Name);
            }

            foreach (var item in studentNumbers)
            {
                Console.WriteLine("{0} --> {1}", item.Name, item.Number);
            }
        }
    }
}
