using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Tasks: create, read, update, Delete

namespace AttendanceSystem
{
    public class AdminService
    {
        private readonly AppDbContext _context;

        public AdminService(AppDbContext context)
        {
            _context = context;
        }

        public void AddAdmin(string name, string username, string password)
        {
            if(name != null && username != null && password != null)
            {
                var admin = new Admin { Name = name, UserName = username, Password = password };
                _context.Admins.Add(admin);
                _context.SaveChanges();
                Console.WriteLine($"Admin({name}) added successfully!");
            }
            else
            {
                Console.WriteLine("Null field cannot be allowed!");
            }

        }

        public List<Admin> GetAllAdmins()
        {
            return _context.Admins.ToList();
        }

        public Admin GetAdminById(int id)
        {
            return _context.Admins.Find(id);
        }

        public void UpdateAdmin(int id, string name, string username, string password)
        {
            var admin = _context.Admins.Find(id);
            if (admin != null)
            {
                admin.Name = name;
                admin.UserName = username;
                admin.Password = password;
                _context.SaveChanges();
                Console.WriteLine($"Admin({admin.Name}) updated successfully!");
            }
            else
            {
                Console.WriteLine($"Admin({name}) not found!");
            }
        }

        public void DeleteAdmin(int id)
        {
            var admin = _context.Admins.Find(id);
            if (admin != null)
            {
                Console.Write($"Admin({admin.Name})");
                _context.Admins.Remove(admin);
                _context.SaveChanges();
                Console.WriteLine(" deleted successfully!");
            }
            else
            {
                Console.WriteLine($"Admin(ID: {id}) not found!");
            }
        }
    }
}
