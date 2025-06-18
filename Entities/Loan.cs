using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Loan
    {
        public int? Code { get; set; }
        public DateTime LoanDate { get; set; }
        public DateTime ReturnDate { get; set; }
        public int Reader_DNI { get; set; }
        public string Book_ISBN { get; set; }

        public Loan(int? code, DateTime loanDate, DateTime returnDate, int readerDNI, string bookISBN)
        {
            Code = code;
            LoanDate = loanDate;
            ReturnDate = returnDate;
            Reader_DNI = readerDNI;
            Book_ISBN = bookISBN;
        }
    }
}
