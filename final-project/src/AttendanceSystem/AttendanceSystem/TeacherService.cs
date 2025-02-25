using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Tasks: create, read, update, Delete

namespace AttendanceSystem
{
    public class TeacherService
    {
        private readonly AppDbContext _context;

        public TeacherService(AppDbContext context)
        {
            _context = context;
        }

        public void AddTeacher(string name, string username, string password)
        {
            if (name != null && username != null && password != null)
            {
                var teacher = new Teacher { Name = name, UserName = username, Password = password };
                _context.Teachers.Add(teacher);
                _context.SaveChanges();
                Console.WriteLine($"Teacher({name}) added successfully!");
            }
            else
            {
                Console.WriteLine("Null field cannot be allowed!");
            }

        }

        public List<Teacher> GetAllTeacher()
        {
            return _context.Teachers.ToList();
        }

        public Teacher GetTeacherById(int id)
        {
            return _context.Teachers.Find(id);
        }

        public void UpdateTeacher(int id, string name, string username, string password)
        {
            var teacher = _context.Teachers.Find(id);
            if (teacher != null)
            {
                teacher.Name = name;
                teacher.UserName = username;
                teacher.Password = password;
                _context.SaveChanges();
                Console.WriteLine($"Teacher({teacher.Name}) updated successfully!");
            }
            else
            {
                Console.WriteLine($"Teacher({name}) not found!");
            }
        }

        public void DeleteTeacher(int id)
        {
            var teacher = _context.Teachers.Find(id);
            if (teacher != null)
            {
                Console.Write($"Teacher({teacher.Name})");
                _context.Teachers.Remove(teacher);
                _context.SaveChanges();
                Console.WriteLine(" deleted successfully!");
            }
            else
            {
                Console.WriteLine($"Teacher(ID: {id}) not found!");
            }
        }
    }
}
