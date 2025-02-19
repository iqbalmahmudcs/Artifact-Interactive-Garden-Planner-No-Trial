using System;
using System.IO;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;

namespace AttendanceSystem
{
    public static class DataUtility
    {
        public static string GetConnectionString()
        {
            var config = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
                .Build();

            return config.GetConnectionString("DefaultConnection");
        }

        public static void TestDatabaseConnection()
        {
            var connectionString = GetConnectionString();

            try
            {
                using(SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    Console.WriteLine("Succesfully Connected!");
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine("Conncetion Failed!");
            }
        }

    }
}
