using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttendanceSystem
{
    public class UserService
    {
        private readonly AppDbContext _context;
            
        public UserService(AppDbContext context)
        {
            _context = context;
        }

        public User Login(string userName, string password)
        {
            return _context.Users.FirstOrDefault(u => u.UserName == userName && u.Password == password);
        }

    }
}
