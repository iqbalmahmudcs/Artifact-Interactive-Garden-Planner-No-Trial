using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Tasks: create, read, update, Delete

namespace AttendanceSystem
{
    public class StudentService : BaseService<Student>
    {
        public StudentService(AppDbContext context) : base(context) 
        {
            if (context == null)
                throw new ArgumentNullException(nameof(context), "AppDbContext is not properly injected.");
        }

        public void AddStudent(string name, string username, string password)
        {
            var student = new Student { Name = name, UserName = username, Password = password };
            Add(student);  // Use the inherited method from BaseService
        }

        public List<Student> GetAllStudents() => GetAll();  // Use the inherited method from BaseService

        public Student GetStudentById(int id) => GetById(id);  // Use the inherited method from BaseService

        public void UpdateStudent(Student student) => Update(student);  // Use the inherited method from BaseService

        public void DeleteStudent(int id) => Delete(id);  // Use the inherited method from BaseService
    }
}
