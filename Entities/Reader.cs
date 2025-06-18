using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Reader
    {
        public int DNI { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Contact { get; set; }

        public Reader(int dni, string name, string surname, string contact) 
        { 
            DNI = dni;
            Name = name;
            Surname = surname;
            Contact = contact;
        }
    }
}
