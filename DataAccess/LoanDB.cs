using Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class LoanDB
    {
        private static string str = "Data Source=DESKTOP-LCCL1R9;Initial Catalog=LibraryLoan;Integrated Security=True";

        public static DataTable LoadDGV()
        {
            string sql = "SELECT * FROM Loans";
            SqlDataAdapter da = new SqlDataAdapter(sql, str);
            DataTable table = new DataTable();
            da.Fill(table);
            return table;
        }

        public static void Insert(Loan loan)
        {
            using (SqlConnection connection = new SqlConnection(str))
            {
                connection.Open();
                string insert = "INSERT INTO Loans (LoanDate, ReturnDate, Reader_DNI, Book_ISBN) VALUES (@LoanDate, @ReturnDate, @Reader_DNI, @Book_ISBN); SELECT SCOPE_IDENTITY();";
                using (SqlCommand cmd = new SqlCommand(insert, connection))
                {
                    cmd.Parameters.AddWithValue("@LoanDate", loan.LoanDate);
                    cmd.Parameters.AddWithValue("@ReturnDate", loan.ReturnDate);
                    cmd.Parameters.AddWithValue("@Reader_DNI", loan.Reader_DNI);
                    cmd.Parameters.AddWithValue("@Book_ISBN", loan.Book_ISBN);

                    // Retrieve the generated Code and assign it to the object
                    loan.Code = Convert.ToInt32(cmd.ExecuteScalar());
                }
            }
        }

        public static void Delete(int code)
        {
            using (SqlConnection connection = new SqlConnection(str))
            {
                connection.Open();
                string delete = "DELETE FROM Loans WHERE Code = @Code";
                using (SqlCommand cmd = new SqlCommand(delete, connection))
                {
                    cmd.Parameters.AddWithValue("@Code", code);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public static void Update(Loan loan)
        {
            using (SqlConnection connection = new SqlConnection(str))
            {
                connection.Open();
                string update = "UPDATE Loans SET LoanDate = @LoanDate, ReturnDate = @ReturnDate, Reader_DNI = @Reader_DNI, Book_ISBN = @Book_ISBN WHERE Code = @Code";
                using (SqlCommand cmd = new SqlCommand(update, connection))
                {
                    cmd.Parameters.AddWithValue("@Code", loan.Code);
                    cmd.Parameters.AddWithValue("@LoanDate", loan.LoanDate);
                    cmd.Parameters.AddWithValue("@ReturnDate", loan.ReturnDate);
                    cmd.Parameters.AddWithValue("@Reader_DNI", loan.Reader_DNI);
                    cmd.Parameters.AddWithValue("@Book_ISBN", loan.Book_ISBN);

                    cmd.ExecuteNonQuery();
                }
            }
        }

        public static void Truncate()
        {
            using (SqlConnection connection = new SqlConnection(str))
            {
                connection.Open();
                string truncate = "TRUNCATE TABLE Loans";
                using (SqlCommand cmd = new SqlCommand(truncate, connection))
                {
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}