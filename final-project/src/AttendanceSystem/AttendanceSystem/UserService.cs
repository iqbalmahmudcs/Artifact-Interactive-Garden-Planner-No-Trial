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

        public void AddUser(string name, string username, string password, UserRole role)
        {
            var user = new User
            {
                Name = name,
                UserName = username,
                Password = password, 
                Role = role,
                UserType = role.ToString()
            };

            _context.Users.Add(user);
            _context.SaveChanges();
        }

        //public List<User> GetAllUsers() => _context.Users.ToList();

        public User Login(string username, string password)
        {
            return _context.Users.FirstOrDefault(u => u.UserName == username && u.Password == password);
        }

    }
}
