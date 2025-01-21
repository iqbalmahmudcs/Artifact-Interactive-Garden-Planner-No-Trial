using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentGradeCalculator
{
    public class Student
    {
        public string Name {  get; set; }
        public string Id { get; set; }
        public List<int> Marks { get; set; }
        private int TotalMarks {  get; set; }

        private double AverageMarks { get; set; }
        private char Grade { get; set; }

        public void CalculateGrade()
        {
            TotalMarks = Marks.Sum();
            AverageMarks = Marks.Average();

            if (AverageMarks >= 90)
                Grade = 'A';
            else if (AverageMarks >= 80)
                Grade = 'B';
            else if (AverageMarks >= 70)
                Grade = 'C';
            else if (AverageMarks >= 60)
                Grade = 'D';
            else
                Grade = 'F';
            
        }

        public void DisplayResult()
        {
            Console.WriteLine("\n=====Result Sheet=====");
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"ID: {Id}");
            Console.WriteLine($"Total Marks: {TotalMarks}");
            Console.WriteLine($"AverageMarks: {AverageMarks:F2}");
            Console.WriteLine($"Grade: {Grade}");
        }
    }
}
