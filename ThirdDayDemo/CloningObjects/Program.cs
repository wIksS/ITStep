using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloningObjects
{
    class Program
    {
        static void Main(string[] args)
        {
            // swallow copy
            var human = new ClonableHuman("pesho");
            human.Clothes = new Clothes() { Type = ClothingType.TShirt };

            Console.WriteLine(human);
            ClonableHuman clonedHuman = human.Clone() as ClonableHuman;
            Console.WriteLine("------------------");
            Console.WriteLine("Cloned human : ");
            Console.WriteLine(clonedHuman);
            Console.WriteLine("Are equal? --> {0}", human == clonedHuman);

        }
    }
}
