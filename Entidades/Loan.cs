using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Loan
    {
        int Code { get; set; }
        DateTime LoanDate { get; set; }
        DateTime ReturnDate { get; set; }
        int Reader_DNI { get; set; }
        string Book_ISBN { get; set; }
    }
}
