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
    public class ReaderDB
    {

        private static string str = "Data Source=DESKTOP-LCCL1R9;Initial Catalog=LibraryLoan;Integrated Security=True";


        public static DataTable LoadDGV()
        {

            string sql = "SELECT * FROM Readers";

            SqlDataAdapter da = new SqlDataAdapter(sql, str);
            DataTable table = new DataTable();
            da.Fill(table);

            return table;
        }

        public static void Insert(Reader reader)
        {

            using (SqlConnection connection = new SqlConnection(str))
            {
                connection.Open();
                string insert = "insert into Readers values (@DNI, @Name, @Surname, @Contact)";
                using (SqlCommand cmd = new SqlCommand(insert, connection))
                {
                    cmd.Parameters.AddWithValue("@DNI", reader.DNI);
                    cmd.Parameters.AddWithValue("@Name", reader.Name);
                    cmd.Parameters.AddWithValue("@Surname", reader.Surname);
                    cmd.Parameters.AddWithValue("@Contact", reader.Contact);

                    cmd.ExecuteNonQuery();
                }
            }
        }

        public static void Delete(int dni)
        {
            using (SqlConnection connection = new SqlConnection(str))
            {
                connection.Open();
                string insert = "delete from Readers where DNI = @DNI";
                using (SqlCommand cmd = new SqlCommand(insert, connection))
                {
                    cmd.Parameters.AddWithValue("@DNI", dni);

                    cmd.ExecuteNonQuery();
                }
            }
        }

        public static void Update(Reader reader)
        {

            using (SqlConnection connection = new SqlConnection(str))
            {
                connection.Open();
                string update = "Update Readers set Name = @Name, Surname = @Surname, Contact = @Contact where DNI = @DNI";
                using (SqlCommand cmd = new SqlCommand(update, connection))
                {
                    cmd.Parameters.AddWithValue("@DNI", reader.DNI);
                    cmd.Parameters.AddWithValue("@Name", reader.Name);
                    cmd.Parameters.AddWithValue("@Surname", reader.Surname);
                    cmd.Parameters.AddWithValue("@Contact", reader.Contact);

                    cmd.ExecuteNonQuery();

                }
            }
        }

    }
}
