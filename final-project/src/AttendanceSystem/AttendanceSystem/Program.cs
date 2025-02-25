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
    .AddScoped<AdminService>()
    .AddScoped<TeacherService>()
    .AddScoped<StudentService>()
    .AddScoped<CourseService>()
    .BuildServiceProvider();




// Create a Scope to Retrieve Services
// Create a Scope to Retrieve Services
using (var scope = serviceProvider.CreateScope())
{
    var services = scope.ServiceProvider;

    // Get Services
    var adminService = services.GetRequiredService<AdminService>();
    var teacherService = services.GetRequiredService<TeacherService>();
    var studentService = services.GetRequiredService<StudentService>();
    var courseService = services.GetRequiredService<CourseService>();

    // ✅ Check Database Connection
    var context = services.GetRequiredService<AppDbContext>();  // No 'using' block here
    if (context.Database.CanConnect())
        Console.WriteLine("Successfully connected with Database!");
    else
        Console.WriteLine("Failed to connect with Database!");

    // ✅ CRUD Operations Testing
    // 🔹 Add Data
    adminService.AddAdmin("Admin1", "admin1", "pass123");
    teacherService.AddTeacher("Teacher1", "teacher1", "pass123");
    studentService.AddStudent("Student1", "student1", "pass123");
    courseService.AddCourse("C# Fundamentals", 5000);

    // 🔹 Retrieve All Data
    Console.WriteLine("\nAdmins:");
    foreach (var admin in adminService.GetAllAdmins())
        Console.WriteLine($"ID: {admin.Id}, Name: {admin.Name}");

    Console.WriteLine("\nTeachers:");
    foreach (var teacher in teacherService.GetAllTeachers())
        Console.WriteLine($"ID: {teacher.Id}, Name: {teacher.Name}");

    Console.WriteLine("\nStudents:");
    foreach (var student in studentService.GetAllStudents())
        Console.WriteLine($"ID: {student.Id}, Name: {student.Name}");

    Console.WriteLine("\nCourses:");
    foreach (var course in courseService.GetAllCourses())
        Console.WriteLine($"ID: {course.Id}, Name: {course.Name}, Fees: {course.Fees}");

    // 🔹 Update Data
    adminService.UpdateAdmin(new Admin { Id = 1, Name = "UpdatedAdmin1", UserName = "updatedAdmin1", Password = "newPass123" });

    // 🔹 Retrieve By ID
    var updatedAdmin = adminService.GetAdminById(1);
    Console.WriteLine($"\nUpdated Admin: ID: {updatedAdmin.Id}, Name: {updatedAdmin.Name}");

    // 🔹 Delete Data
    adminService.DeleteAdmin(1);
}
