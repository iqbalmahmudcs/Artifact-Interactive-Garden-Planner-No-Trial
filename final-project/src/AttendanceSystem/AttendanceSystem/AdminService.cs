using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace AttendanceSystem
{
    public class AdminService : BaseService<Admin>
    {
        private readonly AppDbContext _context;

        public AdminService(AppDbContext context) : base(context)
        {
            _context = context;
        }

        /// <summary>
        /// Adds a new admin to the system.
        /// </summary>
        public void AddAdmin(string name, string username, string password)
        {
            if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                Console.WriteLine("❌ Error: Name, Username, and Password are required.");
                return;
            }

            if (_context.Admins.Any(a => a.UserName == username))
            {
                Console.WriteLine("❌ Error: Username already exists.");
                return;
            }

            var admin = new Admin
            {
                Name = name,
                UserName = username,
                Password = password // 🔴 Consider password hashing for security
            };

            _context.Admins.Add(admin);
            _context.SaveChanges();

            Console.WriteLine($"✅ Admin '{name}' added successfully!");
        }

        /// <summary>
        /// Retrieves all admins.
        /// </summary>
        public List<Admin> GetAllAdmins() => _context.Admins.ToList();

        /// <summary>
        /// Gets an admin by ID.
        /// </summary>
        public Admin GetAdminById(int id) => _context.Admins.FirstOrDefault(a => a.Id == id);

        /// <summary>
        /// Updates an existing admin.
        /// </summary>
        public void UpdateAdmin(int id, string name, string username, string password)
        {
            var admin = _context.Admins.FirstOrDefault(a => a.Id == id);
            if (admin == null)
            {
                Console.WriteLine("❌ Error: Admin not found.");
                return;
            }

            admin.Name = name;
            admin.UserName = username;
            admin.Password = password; // 🔴 Consider password hashing

            _context.SaveChanges();
            Console.WriteLine($"✅ Admin '{name}' updated successfully!");
        }

        /// <summary>
        /// Deletes an admin.
        /// </summary>
        public void DeleteAdmin(int id)
        {
            var admin = _context.Admins.FirstOrDefault(a => a.Id == id);
            if (admin == null)
            {
                Console.WriteLine("❌ Error: Admin not found.");
                return;
            }

            _context.Admins.Remove(admin);
            _context.SaveChanges();
            Console.WriteLine($"✅ Admin '{admin.Name}' deleted successfully!");
        }

        /// <summary>
        /// Adds a new teacher to the system.
        /// </summary>
        public void AddTeacher(string teacherName, string teacherUsername, string teacherPassword)
        {
            if (string.IsNullOrWhiteSpace(teacherName) || string.IsNullOrWhiteSpace(teacherUsername) || string.IsNullOrWhiteSpace(teacherPassword))
            {
                Console.WriteLine("❌ Error: Name, Username, and Password are required.");
                return;
            }

            if (_context.Teachers.Any(t => t.UserName == teacherUsername))
            {
                Console.WriteLine("❌ Error: Username already exists.");
                return;
            }

            var teacher = new Teacher
            {
                Name = teacherName,
                UserName = teacherUsername,
                Password = teacherPassword, // 🔴 Consider password hashing
                Role = UserRole.Teacher
            };

            _context.Teachers.Add(teacher);
            _context.SaveChanges();
            Console.WriteLine($"✅ Teacher '{teacherName}' added successfully!");
        }
    }
}
