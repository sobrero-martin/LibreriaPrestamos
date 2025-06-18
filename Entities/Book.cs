using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Book
    {
        public string ISBN { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string Publisher { get; set; }
        public int Copies { get; set; }
        public bool Disponibility { get; set; }

        public Book(string isbn, string title, string author, string publisher, int copies, bool disponibility)
        {
            ISBN = isbn;
            Title = title;
            Author = author;
            Publisher = publisher;
            Copies = copies;
            Disponibility = disponibility;
        }
    }
}
