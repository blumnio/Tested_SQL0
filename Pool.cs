using Microsoft.Data.SqlClient;
using System;
using System.Threading.Tasks;

namespace Tested_SQL
{
    class Pool
    {
        static async Task MainPool(string[] args)
        {
            string connectionString = "Server=(localdb)\\mssqllocaldb;Database=master;Trusted_Connection=True;";
            string connectionString2 = "Server=(localdb)\\mssqllocaldb;Database=tempdb;Trusted_Connection=True;";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                await connection.OpenAsync();
                Console.WriteLine(connection.ClientConnectionId);
            }
            using (SqlConnection connection = new SqlConnection(connectionString2))
            {
                await connection.OpenAsync();
                Console.WriteLine(connection.ClientConnectionId);
            }
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                await connection.OpenAsync();
                Console.WriteLine(connection.ClientConnectionId);
            }
            Console.WriteLine("Программа завершила работу.");
            Console.Read();
        }
    }
}
