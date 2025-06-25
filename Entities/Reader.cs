using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Reader
    {
        private int _DNI;
        private string _Name;
        private string _Surname;
        private string _Contact;

        public int DNI
        {
            get { return _DNI; }
            set { _DNI = value; }
        }
        public string Name
        {
            get { return _Name; }
            set { _Name = value; }
        }
        public string Surname
        {
            get { return _Surname; }
            set { _Surname = value; }
        }
        public string Contact
        {
            get { return _Contact; }
            set { _Contact = value; }
        }

        public Reader(int dni, string name, string surname, string contact)
        {
            DNI = dni;
            Name = name;
            Surname = surname;
            Contact = contact;
        }
    }
}
