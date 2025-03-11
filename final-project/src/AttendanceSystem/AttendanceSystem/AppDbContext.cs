using Microsoft.EntityFrameworkCore;

namespace AttendanceSystem
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options) { }

        public DbSet<User> Users { get; set; }
        public DbSet<Admin> Admins { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<ClassSchedule> ClassSchedules { get; set; }
        public DbSet<Attendence> Attendances { get; set; }  // Ensure Attendance entity is defined
        public DbSet<StudentCourse> StudentCourses { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Many-to-many relationship between Students and Courses
            modelBuilder.Entity<StudentCourse>()
                .HasKey(sc => new { sc.StudentId, sc.CourseId });

            modelBuilder.Entity<StudentCourse>()
                .HasOne(sc => sc.Student)
                .WithMany(s => s.EnrolledCourse)  // This should match the 'EnrolledCourses' property in Student class
                .HasForeignKey(sc => sc.StudentId);

            modelBuilder.Entity<StudentCourse>()
                .HasOne(sc => sc.Course)
                .WithMany(c => c.EnrolledStudents)
                .HasForeignKey(sc => sc.CourseId);

            // Course entity: specifying precision for the 'Fees' property
            modelBuilder.Entity<Course>()
                .Property(c => c.Fees)
                .HasColumnType("decimal(18,2)");

            // Discriminator setup for the User entity (for inheritance)
            modelBuilder.Entity<User>()
                .HasDiscriminator<string>("UserType")  // Define the discriminator column name
                .HasValue<User>("User")               // Base class
                .HasValue<Admin>("Admin")             // Derived class Admin
                .HasValue<Teacher>("Teacher")         // Derived class Teacher
                .HasValue<Student>("Student");        // Derived class Student
        }
    }
}
