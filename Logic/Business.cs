using DataAccess;
using Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public class Business
    {

        #region Books
        public static string InsertBook(string isbnText, string titleText, string authorText, string publisherText, string copiesInt)
        {

            if (string.IsNullOrWhiteSpace(isbnText))
            {
                return "The ISBN cannot be empty";
            }
            if (string.IsNullOrWhiteSpace(titleText))
            {
                return "The title cannot be empty";
            }
            if (string.IsNullOrWhiteSpace(authorText))
            {
                return "The author cannot be empty";
            }
            if (string.IsNullOrWhiteSpace(publisherText))
            {
                return "The publisher cannot be empty";
            }
            if (authorText.All(char.IsDigit))
            {
                return "The author's name cannot contain only numbers.";  
            }
            if (string.IsNullOrWhiteSpace(copiesInt) || !int.TryParse(copiesInt, out int result))
            {
                return "The number of copies must be a valid numeric value.";
            }

            bool disponibility = result > 0;
            if (result < 0)
            {
                return "The number of copies cannot be negative.";
            }

            Book book = new Book(isbnText, titleText, authorText, publisherText, result, disponibility);
            BookDB.Insert(book);

            return null;
        }

        public static string UpdateBook(string isbnText, string titleText, string authorText, string publisherText, string copiesInt)
        {
            if (string.IsNullOrWhiteSpace(isbnText))
            {
                return "The ISBN cannot be empty";
            }
            if (string.IsNullOrWhiteSpace(titleText))
            {
                return "The title cannot be empty";
            }
            if (string.IsNullOrWhiteSpace(authorText))
            {
                return "The author cannot be empty";
            }
            if (string.IsNullOrWhiteSpace(publisherText))
            {
                return "The publisher cannot be empty";
            }
            if (authorText.All(char.IsDigit))
            {
                return "The author's name cannot contain only numbers.";
            }
            if (string.IsNullOrWhiteSpace(copiesInt) || !int.TryParse(copiesInt, out int result))
            {
                return "The number of copies must be a valid numeric value.";
            }

            bool disponibility = result > 0;
            if (result < 0)
            {
                return "The number of copies cannot be negative.";
            }

            Book book = new Book(isbnText, titleText, authorText, publisherText, result, disponibility);
            BookDB.Update(book);

            return null;
        }

        public static string DeleteBook(string isbnText)
        {
            if (string.IsNullOrWhiteSpace(isbnText))
            {
                return "The ISBN cannot be empty";
            }

            BookDB.Delete(isbnText);
            return null;
        }

        public static DataTable GetBooks()
        {
            return BookDB.LoadDGV();
        }
        #endregion

        #region Readers
        public static string InsertReader(string dniText, string nameText, string surnameText, string contactText)
        {
            if (string.IsNullOrWhiteSpace(dniText) || !int.TryParse(dniText, out int dni))
            {
                return "The DNI must be a valid numeric value.";
            }
            if (string.IsNullOrWhiteSpace(nameText))
            {
                return "The name cannot be empty.";
            }
            if (string.IsNullOrWhiteSpace(surnameText))
            {
                return "The surname cannot be empty.";
            }
            if (string.IsNullOrWhiteSpace(contactText))
            {
                return "The contact cannot be empty.";
            }
            if (nameText.All(char.IsDigit))
            {
                return "The name cannot contain only numbers.";
            }
            if (surnameText.All(char.IsDigit))
            {
                return "The surname cannot contain only numbers.";
            }

            Reader reader = new Reader(dni, nameText, surnameText, contactText);
            ReaderDB.Insert(reader);
            return null;
        }

        public static string UpdateReader(string dniText, string nameText, string surnameText, string contactText)
        {
            if (string.IsNullOrWhiteSpace(dniText) || !int.TryParse(dniText, out int dni))
            {
                return "The DNI must be a valid numeric value.";
            }
            if (string.IsNullOrWhiteSpace(nameText))
            {
                return "The name cannot be empty.";
            }
            if (string.IsNullOrWhiteSpace(surnameText))
            {
                return "The surname cannot be empty.";
            }
            if (string.IsNullOrWhiteSpace(contactText))
            {
                return "The contact cannot be empty.";
            }
            if (nameText.All(char.IsDigit))
            {
                return "The name cannot contain only numbers.";
            }
            if (surnameText.All(char.IsDigit))
            {
                return "The surname cannot contain only numbers.";
            }

            Reader reader = new Reader(dni, nameText, surnameText, contactText);
            ReaderDB.Update(reader);
            return null;
        }

        public static string DeleteReader(string dniText)
        {
            if (string.IsNullOrWhiteSpace(dniText) || !int.TryParse(dniText, out int dni))
            {
                return "The DNI must be a valid numeric value.";
            }

            ReaderDB.Delete(dni);
            return null;
        }

        public static DataTable GetReaders()
        {
            return ReaderDB.LoadDGV();
        }
        #endregion
        public static string InsertLoan(DateTime loanDate, DateTime returnDate, bool returned, string readerDniText, string bookIsbnText)
        {

            if (returnDate < loanDate)
            {
                return "The return date cannot be before the loan date.";
            }
            if (string.IsNullOrWhiteSpace(readerDniText) || !int.TryParse(readerDniText, out int readerDni))
            {
                return "The Reader DNI must be a valid numeric value.";
            }
            if (string.IsNullOrWhiteSpace(bookIsbnText))
            {
                return "The Book ISBN cannot be empty.";
            }

            Loan loan = new Loan(null, loanDate, returnDate, returned, readerDni, bookIsbnText);
            LoanDB.Insert(loan);
            return null;
        }

        public static DataTable GetLoans()
        {
            return LoanDB.LoadDGV();
        }
    }
}
