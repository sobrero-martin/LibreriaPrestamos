using Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class BookDB
    {
        private static string str = "Data Source=DESKTOP-LCCL1R9;Initial Catalog=LibraryLoan;Integrated Security=True";

        public static DataTable LoadDGV()
        {

            string sql = "SELECT * FROM Books";

            SqlDataAdapter da = new SqlDataAdapter(sql, str);
            DataTable table = new DataTable();
            da.Fill(table);

            return table;
        }

        public static void Insert(Book book)
        {

            using (SqlConnection connection = new SqlConnection(str))
            {
                connection.Open();
                string insert = "insert into Books values (@ISBN, @Title, @Author, @Publisher, @Copies, @Disponibility)";
                using (SqlCommand cmd = new SqlCommand(insert, connection))
                {
                    cmd.Parameters.AddWithValue("@ISBN", book.ISBN);
                    cmd.Parameters.AddWithValue("@Title", book.Title);
                    cmd.Parameters.AddWithValue("@Author", book.Author);
                    cmd.Parameters.AddWithValue("@Publisher", book.Publisher);
                    cmd.Parameters.AddWithValue("@Copies", book.Copies);
                    cmd.Parameters.AddWithValue("@Disponibility", book.Disponibility);

                    cmd.ExecuteNonQuery();
                }
            }
        }

        public static void Delete(string isbn)
        {
            using (SqlConnection connection = new SqlConnection(str))
            {
                connection.Open();
                string insert = "delete from Books where ISBN = @ISBN";
                using (SqlCommand cmd = new SqlCommand(insert, connection))
                {
                    cmd.Parameters.AddWithValue("@ISBN", isbn);

                    cmd.ExecuteNonQuery();
                }
            }
        }

        public static void Update(Book book)
        {

            using (SqlConnection connection = new SqlConnection(str))
            {
                connection.Open();
                string update = "Update Books set ISBN = @ISBN, Title = @Title, Author = @Author, Publisher = @Publisher, Copies = @Copies, Disponibility = @Disponibility where ISBN = @ISBN";
                using (SqlCommand cmd = new SqlCommand(update, connection))
                {
                    cmd.Parameters.AddWithValue("@ISBN", book.ISBN);
                    cmd.Parameters.AddWithValue("@Title", book.Title);
                    cmd.Parameters.AddWithValue("@Author", book.Author);
                    cmd.Parameters.AddWithValue("@Publisher", book.Publisher);
                    cmd.Parameters.AddWithValue("@Copies", book.Copies);
                    cmd.Parameters.AddWithValue("@Disponibility", book.Disponibility);

                    cmd.ExecuteNonQuery();
                }
            }
        }

    }
}
