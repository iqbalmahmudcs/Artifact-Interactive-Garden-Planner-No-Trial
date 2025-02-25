using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Tasks: create, read, update, Delete

namespace AttendanceSystem
{
    public class AdminService : BaseService<Admin>
    {
        private readonly AppDbContext _context;

        public AdminService(AppDbContext context) : base(context)
        {
            _context = context;
        }

        public void AddAdmin(string name, string username, string password)
        {
            var admin = new Admin { Name = name, UserName = username, Password = password };
            _context.Admins.Add(admin);
            _context.SaveChanges();
        }

        public List<Admin> GetAllAdmins() => _context.Admins.ToList();  // Use _context directly
        public Admin GetAdminById(int id) => _context.Admins.FirstOrDefault(a => a.Id == id);  // Use _context directly

        public void UpdateAdmin(Admin admin)
        {
            _context.Admins.Update(admin);
            _context.SaveChanges();
        }

        public void DeleteAdmin(int id)
        {
            var admin = _context.Admins.FirstOrDefault(a => a.Id == id);
            if (admin != null)
            {
                _context.Admins.Remove(admin);
                _context.SaveChanges();
            }
        }
    }

}
