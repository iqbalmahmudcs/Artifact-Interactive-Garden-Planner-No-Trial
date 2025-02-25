using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Tasks: create, read, update, Delete

namespace AttendanceSystem
{
    public class StudentService
    {
        private readonly AppDbContext _context;

        public StudentService(AppDbContext context)
        {
            _context = context;
        }

        public void AddStudent(string name, string username, string password)
        {
            if (name != null && username != null && password != null)
            {
                var student = new Student { Name = name, UserName = username, Password = password };
                _context.Students.Add(student);
                _context.SaveChanges();
                Console.WriteLine($"Student({name}) added successfully!");
            }
            else
            {
                Console.WriteLine("Null field cannot be allowed!");
            }

        }

        public List<Student> GetAllStudent()
        {
            return _context.Students.ToList();
        }

        public Student GetStudentById(int id)
        {
            return _context.Students.Find(id);
        }

        public void UpdateStudent(int id, string name, string username, string password)
        {
            var student = _context.Students.Find(id);
            if (student != null)
            {
                student.Name = name;
                student.UserName = username;
                student.Password = password;
                _context.SaveChanges();
                Console.WriteLine($"Stuudent({student.Name}) updated successfully!");
            }
            else
            {
                Console.WriteLine($"Student({name}) not found!");
            }
        }

        public void DeleteStudent(int id)
        {
            var student = _context.Students.Find(id);
            if (student != null)
            {
                Console.Write($"Student({student.Name})");
                _context.Students.Remove(student);
                _context.SaveChanges();
                Console.WriteLine(" deleted successfully!");
            }
            else
            {
                Console.WriteLine($"Student(ID: {id}) not found!");
            }
        }
    }
}
