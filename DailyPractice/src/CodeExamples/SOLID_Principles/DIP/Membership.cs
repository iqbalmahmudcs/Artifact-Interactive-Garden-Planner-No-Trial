using ADONetExample;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Principles.DIP
{
    public class Membership
    {
        private IDb _db;

        public Membership(IDb db)
        {
            _db = db;
        }

        public void CreateUser(string username, string password)
        {
            if(!string.IsNullOrEmpty(username) && !string.IsNullOrEmpty(password))
            {
                _db.RunSql("");
            }
        }
    }
}
