using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    public class Student
    {
        private double grade;


        public void SetGrade(double grade)
        {
            if (grade >= 0 && grade <= 100)
            {
                this.grade = grade;
            }
            else
                Console.WriteLine($"Invalid Grade({grade}). Please enter a valid grade(0-100).");
        }

        public double GetGrade()
        {
            return grade;   
        }
    }
}
