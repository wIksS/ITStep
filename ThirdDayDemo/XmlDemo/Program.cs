using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace XmlDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Book> books = GenerateBooks();

            XmlSerializer serializer = new XmlSerializer(typeof(Book));

            using (XmlWriter xmlWriter = XmlWriter.Create("../../xmlBook.xml"))
            {
                serializer.Serialize(xmlWriter, books[0]);
            }

            using (XmlReader reader = XmlReader.Create("../../xmlBook.xml"))
            {
                Book book = serializer.Deserialize(reader) as Book;

                Console.WriteLine(book);
            }
        }

        private static List<Book> GenerateBooks()
        {
            var books = new List<Book>();
            for (int i = 0; i < 10; i++)
            {
                books.Add(BooksFactory.Create());
            }

            return books;
        }
    }
}
