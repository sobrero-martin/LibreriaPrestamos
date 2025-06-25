using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Book
    {
        private string _ISBN;
        private string _Title;
        private string _Author;
        private string _Publisher;
        private int _Copies;
        private bool _Disponibility;

        public string ISBN
        {
            get { return _ISBN; }
            set { _ISBN = value; }
        }
        public string Title
        {
            get { return _Title; }
            set { _Title = value; }
        }
        public string Author
        {
            get { return _Author; }
            set { _Author = value; }
        }
        public string Publisher
        {
            get { return _Publisher; }
            set { _Publisher = value; }
        }
        public int Copies
        {
            get { return _Copies; }
            set { _Copies = value; }
        }
        public bool Disponibility
        {
            get { return _Disponibility; }
            set { _Disponibility = value; }
        }

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
