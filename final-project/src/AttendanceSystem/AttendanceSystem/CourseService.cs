using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Tasks: create, read, update, Delete

namespace AttendanceSystem
{
    public class CourseService : BaseService<Course>
    {
        public CourseService(AppDbContext context) : base(context) { }

        public void AddCourse(string name, decimal fees)
        {
            var course = new Course { Name = name, Fees = fees };
            Add(course);  // Directly call the base class Add method
        }

        public List<Course> GetAllCourses() => GetAll();  // Directly call the base class GetAll method

        public Course GetCourseById(int id) => GetById(id);  // Directly call the base class GetById method

        public void UpdateCourse(Course course) => Update(course);  // Directly call the base class Update method

        public void DeleteCourse(int id) => Delete(id);  // Directly call the base class Delete method
    }
}
