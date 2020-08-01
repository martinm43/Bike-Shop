using System;
using System.Data.SqlClient;

namespace Bike_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            // Integrated Security=SSPI is required for Windows Authentication login.
            var cs = @"Server=localhost\SQLEXPRESS;Database=bikeshop;Trusted_Connection=True;Integrated Security=SSPI;";
            var stm = "SELECT @@VERSION";

            using var con = new SqlConnection(cs);
            con.Open();

            using var cmd = new SqlCommand(stm, con);
            string version = cmd.ExecuteScalar().ToString();

            Console.WriteLine(version);
        }
    }
}