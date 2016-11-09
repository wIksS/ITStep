using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace XmlDemo
{
    public class Book
    {
        [XmlElement(ElementName= "UniqueIdentificator")]
        public int Id { get; set; }

        public string Author { get; set; }

        [XmlElement(ElementName ="BookName")]
        public string Title { get; set; }

        public string Genre { get; set; }

        public decimal Price { get; set; }

        public DateTime PublishDate { get; set; }

        public string Description { get; set; }

        public override string ToString()
        {
            return String.Format("{0} --> {1} --> {2} --> {3}", this.Title, this.Author,this.Description, this.Id);
        }
    }
}
