using Microsoft.Data.SqlClient;
using System;
using System.Threading.Tasks;

namespace Tested_SQL
{
    class Connection
    {
        static async Task Main(string[] args)
        {
            string connectionString = "Server=(localdb)\\mssqllocaldb;Database=master;Trusted_Connection=True;";
            //To save space and code volume, instead of explicitly closing the connection, you can also use the "using" construct, which automatically closes the connection
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                await connection.OpenAsync();
                Console.WriteLine("Connection is open");
                //Output of connection information
                Console.WriteLine("Connection Properties:");
                Console.WriteLine($"\tConnection string: {connection.ConnectionString}");
                Console.WriteLine($"\tDataBase: {connection.Database}");
                Console.WriteLine($"\tServer: {connection.DataSource}");
                Console.WriteLine($"\tServer version: {connection.ServerVersion}");
                Console.WriteLine($"\tState: {connection.State}");
                Console.WriteLine($"\tWorkStationID: {connection.WorkstationId}");
            }
            Console.WriteLine("Connection is close...");
            Console.WriteLine("The program has finished working");
            Console.Read();
        }
    }
}
