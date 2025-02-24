using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_2
{
    public struct Student
    {
        private string Name { get; set; }
        private int Age { get; set; }
        private double Gpa { get; set; }

        public Student(string name, int age, double gpa)
        {
            Name = name;
            Age = age;
            Gpa = gpa;
        }

        public void Display()
        {
            Console.WriteLine($"Name: {Name}\nAge: {Age}\nGPA: {Gpa}");
        }
    }
}
