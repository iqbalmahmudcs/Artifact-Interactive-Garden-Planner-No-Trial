using AttendanceSystem;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;

//Load Configuration => appsetting.json
var configuration = new ConfigurationBuilder()
    .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
    .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
    .Build();

//Dependency Injection
var serviceProvider = new ServiceCollection()
    .AddDbContext<AppDbContext>(options => options.UseSqlServer(configuration.GetConnectionString("DefaultConnection")))
    .BuildServiceProvider();


//Database Connectivity Checking
using (var context = serviceProvider.GetRequiredService<AppDbContext>())
{
    if (context.Database.CanConnect())
        Console.WriteLine("Successfully connected with Database!");
    else
        Console.WriteLine("Failed to connect with Database!");
}


