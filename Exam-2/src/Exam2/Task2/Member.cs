using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public class Member
    {
        public string? Name { get; set; }
        public AccountStatus AccountStatus { get; set; } // 0 = InActive, 1 = Active, 2 = Blocked

        public override string ToString()
        {
            return $"Name: {Name}. Status: {AccountStatus}";
        }
    }
}
