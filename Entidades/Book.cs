using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Book
    {
        string ISBN {  get; set; }
        string Title { get; set; }
        string Author {  get; set; }
        string Publisher { get; set; }
        int Copies { get; set; }
        bool Disponibility { get; set; }
    }
}
