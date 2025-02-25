using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Tasks: create, read, update, Delete

namespace AttendanceSystem
{
    public class CourseService
    {
        private readonly AppDbContext _context;

        public CourseService(AppDbContext context)
        {
            _context = context;
        }

        public void AddCourse(string name, decimal fees)
        {
            if (name != null && fees != null)
            {
                var course = new Course { Name = name, Fees = fees };
                _context.Courses.Add(course);
                _context.SaveChanges();
                Console.WriteLine("");
            }
            else
                Console.WriteLine("Null field cannot be allowed!");
        }

        public List<Course> GetAllCourses()
        {
            return _context.Courses.ToList();
        }

        public Course GetCourseById(int id)
        {
            return _context.Courses.Find(id);
        }

        public void UpdateCourse(int id, string name, decimal fees)
        {
            var course = _context.Courses.Find(id);
            if(course != null)
            {
                course.Name = name;
                course.Fees = fees;
                _context.SaveChanges();
                Console.WriteLine($"Course({course.Name}) updated successfully!");
            }
            else
            {
                Console.WriteLine($"Course({name}) not found!");
            }
        }

        public void DeleteCourse(int id)
        {
            var course = _context.Courses.Find(id);
            if (course != null)
            {
                Console.Write($"Course({course.Name})");
                _context.Courses.Remove(course);
                _context.SaveChanges();
                Console.WriteLine(" deleted successfully!");
            }
            else
            {
                Console.WriteLine($"Course(ID: {id}) not found!");
            }
        }
    }
}
