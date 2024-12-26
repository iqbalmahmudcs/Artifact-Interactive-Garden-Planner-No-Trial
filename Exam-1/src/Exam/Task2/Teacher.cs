using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public class Teacher : Person
    {
        public String Department { get; set; }
        public string Subject { get; set; }

        public override void DisplayDetails()
        {
            Console.WriteLine($"Teacher Details:");
            Console.WriteLine($"---------------");
            Console.WriteLine($"Name: {FirstName + " " + LasttName}");
            Console.WriteLine($"Date Of Birth: {DateOfBirth}");
            Console.WriteLine($"Department: {Department}");
            Console.WriteLine($"Subject: {Subject}");
        }

        public string GenerateId()
        {
            return "T" + FirstName;
        }
    }
}
