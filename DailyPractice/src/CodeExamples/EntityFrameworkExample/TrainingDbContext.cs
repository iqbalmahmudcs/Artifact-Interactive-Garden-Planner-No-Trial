using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkExample
{
    public class TrainingDbContext : DbContext 
    {
        private readonly string _connectionString;

        public TrainingDbContext()
        {
            _connectionString = "Server=OFFICER-IT-DHAK\\SQLEXPRESS;Database=CSharpB19;User Id=csharpb19;Password=asdf1234Z@; Trust Server Certificate=True";
        }
        
        public TrainingDbContext(string connection)
        {
            _connectionString = connection;
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(_connectionString);
            }
            base.OnConfiguring(optionsBuilder);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Topic>().ToTable("Topics");
            modelBuilder.Entity<CourseStudent>().ToTable("CourseStudents");

            //Composit Primary Key
            modelBuilder.Entity<CourseStudent>().HasKey(x => new { x.CourseId, x.StudentId });

            base.OnModelCreating(modelBuilder);
        }
        public DbSet<Course> Courses {  get; set; }
        public DbSet<Student> Students { get;  set;}
    }
}
