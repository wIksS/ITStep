using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileIO
{
    class Program
    {
        static void Main(string[] args)
        {
            using (StreamWriter writer = new StreamWriter("../../text.txt",true, Encoding.UTF8))
            {                
                writer.WriteLine("Кирилица");
                writer.WriteLine("Second HI!");
            }

            using (StreamReader reader = new StreamReader("../../text.txt"))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                }

                //string text = reader.ReadToEnd();
                //Console.WriteLine(text);
            }            
        }
    }
}
