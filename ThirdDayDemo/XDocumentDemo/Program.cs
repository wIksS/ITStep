using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace XDocumentDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            XDocument document = null;
            for (int i = 0; i < 10; i++)
            {
                document = new XDocument(
                   new XDeclaration("1.0", "utf-8", "yes"),
                   new XElement("Catalog",
                       new XElement("Book", "Крадецът на книги"),
                       new XElement("Book", "1984"),
                       new XElement("Book", "Хари Потър"),
                       new XElement("Book", "C# за напреднали")
                   )
               );
            }

            document.Save("../../books.xml");
        }
    }
}
