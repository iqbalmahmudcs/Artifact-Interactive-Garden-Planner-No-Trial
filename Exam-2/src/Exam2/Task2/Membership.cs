using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public class Membership
    {
        public Member SetMembershipStatus(string name, AccountStatus status)
        {
            return new Member() { Name = name, AccountStatus = status }; 
        }
    }
}
