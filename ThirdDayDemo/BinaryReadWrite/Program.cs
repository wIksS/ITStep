using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryReadWrite
{
    class Program
    {
        static void Main(string[] args)
        {
            using (BinaryWriter writer = new BinaryWriter(File.Open("../../binary.bin", FileMode.Create)))
            {
                writer.Write(28);
            }

            using (BinaryReader reader = new BinaryReader(File.Open("../../binary.bin", FileMode.Open)))
            {
                int integerValue = reader.ReadInt32();
                Console.WriteLine(integerValue); 
            }
        }
    }
}
