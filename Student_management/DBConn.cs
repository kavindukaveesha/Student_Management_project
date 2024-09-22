using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Student_management
{
    public class DBConn
    {
        static string connectionString = "Data Source=Kavindu\\SQLEXPRESS;Initial Catalog=Students;Integrated Security=True;";   // Kavindu
                                                                                                                                 // static string connectionString = "Data Source=Revision-PC\\SQLEXPRESS;Initial Catalog=Students;Integrated Security=True;"; // Prasad

        static public SqlCommand getCommand(string query)
        {
            SqlConnection con = new SqlConnection(connectionString);



            try
            {
                con.Open();

                SqlCommand cmd = new SqlCommand(query, con);
                Console.WriteLine("connection success");

                return cmd;
            }
            catch (SqlException ex)
            {
                Console.WriteLine("SQL Error: " + ex.Message);
            }


            return null;
        }

    }
}
