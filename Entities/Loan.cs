using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Loan
    {
        private int? _Code;
        private DateTime _LoanDate;
        private DateTime _ReturnDate;
        private bool _Returned;
        private int _Reader_DNI;
        private string _Book_ISBN;

        public int? Code
        {
            get { return _Code; }
            set { _Code = value; }
        }
        public DateTime LoanDate
        {
            get { return _LoanDate; }
            set { _LoanDate = value; }
        }
        public DateTime ReturnDate
        {
            get { return _ReturnDate; }
            set { _ReturnDate = value; }
        }
        public bool Returned
        {
            get { return _Returned; }
            set { _Returned = value; }
        }
        public int Reader_DNI
        {
            get { return _Reader_DNI; }
            set { _Reader_DNI = value; }
        }
        public string Book_ISBN
        {
            get { return _Book_ISBN; }
            set { _Book_ISBN = value; }
        }

        public Loan(int? code, DateTime loanDate, DateTime returnDate, bool returned, int readerDNI, string bookISBN)
        {
            Code = code;
            LoanDate = loanDate;
            ReturnDate = returnDate;
            Returned = returned;
            Reader_DNI = readerDNI;
            Book_ISBN = bookISBN;
        }
    }
}
