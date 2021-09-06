using Microsoft.Data.SqlClient;
using System;
using System.Data;
using System.Threading.Tasks;

namespace Tested_SQL
{
    class KEKW
    {
        static async Task Main(string[] args)
        {
            string connectionString = "Server=(localdb)\\mssqllocaldb;Database=master;Trusted_Connection=True;";

            //Create connection
            SqlConnection connection = new SqlConnection(connectionString);
            try
            {
                //Open connection
                await connection.OpenAsync();
                Console.WriteLine("Connection is open");
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                //If connection is open
                if (connection.State == ConnectionState.Open)
                { //We close conneetion
                    await connection.CloseAsync();
                    Console.WriteLine("Connection is close...");
                }
            }
            Console.WriteLine("The program has finished working.");
            Console.Read();
        }
    }
}
