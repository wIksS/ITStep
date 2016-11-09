using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XmlDemo
{
    public class BooksFactory
    {
        public static Book Create()
        {
            Book book = new Book();
            book.Author = "Pesho";
            book.Title = "The best book";
            book.Description = "Description";
            book.Id = new Random().Next(0, 1000);

            return book;
        }
    }
}
