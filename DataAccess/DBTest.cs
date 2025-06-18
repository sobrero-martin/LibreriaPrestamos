using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class DBTest
    {

        public static void Main()
        {
            SqlConnection conexion = new SqlConnection("Data Source=DESKTOP-LCCL1R9;Initial Catalog=LibraryLoan;Integrated Security=True");
            conexion.Open();

            string insert = "insert into Readers values (34567867, 'Pepe', 'Rodríguez', 'peper@gmail.com')";

            SqlCommand cmd = new SqlCommand(insert, conexion);
            int cantidad = cmd.ExecuteNonQuery();

            conexion.Close();
        }

        public static void Insert(int dni, string name, string surname, string contact, string table)
        {
            string cdn = "Data Source=DESKTOP-LCCL1R9;Initial Catalog=LibraryLoan;Integrated Security=True";
            SqlConnection conexion = new SqlConnection(cdn);
            conexion.Open();

            string insert = "insert into " + table + " values (" + dni + ", '" + name + "', '" + surname + "', '" + contact + "')";
            SqlCommand cmd = new SqlCommand(insert, conexion);
            cmd.ExecuteNonQuery();

            conexion.Close();
        }

        public static DataTable LoadDGV()
        {
             string cdn = "Data Source=DESKTOP-LCCL1R9;Initial Catalog=LibraryLoan;Integrated Security=True"; 

             string sql = "SELECT * FROM Readers";

             SqlDataAdapter da = new SqlDataAdapter(sql, cdn);
             DataTable table = new DataTable();
             da.Fill(table);

             return table;
        }
    }
}
