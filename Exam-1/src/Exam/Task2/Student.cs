using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public class Student : Person
    {
        public int Grade { get; set; }

        public override void DisplayDetails()
        {
            Console.WriteLine($"Student Details:");
            Console.WriteLine($"---------------");
            Console.WriteLine($"Name: {FirstName+ " " +LasttName}");
            Console.WriteLine($"Date Of Birth: {DateOfBirth}");
            Console.WriteLine($"Grade: {Grade}");
        }

        public string GenerateId()
        {
            return "S" + FirstName;
        }
    }
}
