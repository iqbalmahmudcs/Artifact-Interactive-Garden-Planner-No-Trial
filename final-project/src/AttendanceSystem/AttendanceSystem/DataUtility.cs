using System;
using System.IO;
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
    }
}
