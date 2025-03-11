using AttendanceSystem;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;

// Load Configuration => appsettings.json
var configuration = new ConfigurationBuilder()
    .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
    .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
    .Build();

// Dependency Injection
var serviceProvider = new ServiceCollection()
    .AddDbContext<AppDbContext>(options => options.UseSqlServer(configuration.GetConnectionString("DefaultConnection")))
    .AddScoped<UserService>()
    .AddScoped<AdminService>()
    .AddScoped<TeacherService>()
    .AddScoped<StudentService>()
    .AddScoped<CourseService>()
    .BuildServiceProvider();

using (var scope = serviceProvider.CreateScope())
{
    var services = scope.ServiceProvider;

    var userService = services.GetRequiredService<UserService>();
    var adminService = services.GetRequiredService<AdminService>();
    var teacherService = services.GetRequiredService<TeacherService>();
    var studentService = services.GetRequiredService<StudentService>();
    var courseService = services.GetRequiredService<CourseService>();
    var context = services.GetRequiredService<AppDbContext>();

    // Check database connection
    if (context.Database.CanConnect())
        Console.WriteLine("Successfully connected to the Database!");
    else
    {
        Console.WriteLine("Failed to connect to Database!");
        return; // Exit if database is not connected
    }

    Console.WriteLine("\nWelcome to the Attendance System!\n");

    // Step 1: Login
    Console.Write("Username: ");
    string username = Console.ReadLine();
    Console.Write("Password: ");
    string password = Console.ReadLine();

    var user = userService.Login(username, password);
    if (user != null)
    {
        Console.WriteLine($"\nLogin successful. Welcome, {user.Name}!\n");
        GrantPermissions(user, adminService, teacherService, studentService, courseService);
    }
    else
    {
        Console.WriteLine("Invalid login credentials.");
    }
}

    // Grants permissions based on user role.
    static void GrantPermissions(User user, AdminService adminService, TeacherService teacherService, StudentService studentService, CourseService courseService)
{
    switch (user.Role)
    {
        case UserRole.Admin:
            Console.WriteLine("You are logged in as an Admin.");
            ShowAdminMenu(adminService);
            break;
        case UserRole.Teacher:
            Console.WriteLine("You are logged in as a Teacher.");
            ShowTeacherMenu(teacherService);
            break;
        case UserRole.Student:
            Console.WriteLine("You are logged in as a Student.");
            ShowStudentMenu(studentService);
            break;
        default:
            Console.WriteLine("Invalid Role!");
            break;
    }
}

/// Admin Menu Options
static void ShowAdminMenu(AdminService adminService)
{
    while (true)
    {
        Console.WriteLine("\nAdmin Menu:");
        Console.WriteLine("1️ Add Teacher");
        Console.WriteLine("2️ Add Course");
        Console.WriteLine("3️ Add Student");
        Console.WriteLine("4️ Assign Teacher to Course");
        Console.WriteLine("5️ Assign Student to Course");
        Console.WriteLine("6️ Set Class Schedule");
        Console.WriteLine("7️ Exit");

        Console.Write("\nEnter your choice: ");
        string choice = Console.ReadLine();

        switch (choice)
        {
            case "1":
                Console.Write("Enter Teacher Name: ");
                string teacherName = Console.ReadLine();
                Console.Write("Enter Username: ");
                string teacherUsername = Console.ReadLine();
                Console.Write("Enter Password: ");
                string teacherPassword = Console.ReadLine();
                adminService.AddTeacher(teacherName, teacherUsername, teacherPassword);
                Console.WriteLine("Teacher Added Successfully!");
                break;
            case "7":
                Console.WriteLine("Exiting Admin Menu...");
                return;
            default:
                Console.WriteLine("Invalid choice, try again.");
                break;
        }
    }
}

// Teacher Menu Options
static void ShowTeacherMenu(TeacherService teacherService)
{
    while (true)
    {
        Console.WriteLine("\nTeacher Menu:");
        Console.WriteLine("1️ Check Attendance");
        Console.WriteLine("2️ Exit");

        Console.Write("\nEnter your choice: ");
        string choice = Console.ReadLine();

        switch (choice)
        {
            case "1":
                Console.WriteLine("Checking Attendance...");
                break;
            case "2":
                Console.WriteLine("Exiting Teacher Menu...");
                return;
            default:
                Console.WriteLine("Invalid choice, try again.");
                break;
        }
    }
}

// Student Menu Options
static void ShowStudentMenu(StudentService studentService)
{
    while (true)
    {
        Console.WriteLine("\nStudent Menu:");
        Console.WriteLine("1️ Mark Attendance");
        Console.WriteLine("2️ Exit");

        Console.Write("\nEnter your choice: ");
        string choice = Console.ReadLine();

        switch (choice)
        {
            case "1":
                Console.WriteLine("Marking Attendance...");
                break;
            case "2":
                Console.WriteLine("Exiting Student Menu...");
                return;
            default:
                Console.WriteLine("Invalid choice, try again.");
                break;
        }
    }
}


