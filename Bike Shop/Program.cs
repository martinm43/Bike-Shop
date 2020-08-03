using System;
using System.Data.SqlClient;
using System.IO;
using Microsoft.SqlServer.Management.Smo;
using Microsoft.SqlServer.Management.Common;

namespace Bike_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            // Integrated Security=SSPI is required for Windows Authentication login.
            string cs = @"Server=localhost\SQLEXPRESS;Database=bikeshop;Trusted_Connection=True;Integrated Security=SSPI;";
            string script = File.ReadAllText(@"C:\Users\Owner.Owner-PC\source\repos\Bike Shop\most_valuable_customers.sql");
            SqlConnection conn = new SqlConnection(cs);
            conn.Open();
            SqlCommand command = new SqlCommand(script, conn);

            SqlDataReader dataReader = command.ExecuteReader();
            while (dataReader.Read())
            {
                Console.WriteLine(dataReader.GetValue(0) + "," + dataReader.GetValue(1) + "," + dataReader.GetValue(2) + ","+ dataReader.GetValue(3) + ","+dataReader.GetValue(4));
            }
            dataReader.Close();
            command.Dispose();
            conn.Close();
        }
    }
}