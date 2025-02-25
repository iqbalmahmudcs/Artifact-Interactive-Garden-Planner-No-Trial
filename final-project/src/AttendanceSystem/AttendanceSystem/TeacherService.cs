using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Tasks: create, read, update, Delete

namespace AttendanceSystem
{
    public class TeacherService : BaseService<Teacher>
    {
        public TeacherService(AppDbContext context) : base(context) { }

        public void AddTeacher(string name, string username, string password)
        {
            var teacher = new Teacher { Name = name, UserName = username, Password = password };
            Add(teacher);  // Use the inherited method from BaseService
        }

        public List<Teacher> GetAllTeachers() => GetAll();  // Use the inherited method from BaseService

        public Teacher GetTeacherById(int id) => GetById(id);  // Use the inherited method from BaseService

        public void UpdateTeacher(Teacher teacher) => Update(teacher);  // Use the inherited method from BaseService

        public void DeleteTeacher(int id) => Delete(id);  // Use the inherited method from BaseService
    }
}
