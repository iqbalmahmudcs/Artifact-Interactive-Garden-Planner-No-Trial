using StudentGradeCalculator;
using System.Threading.Channels;
Console.WriteLine("Welcome to the Student Grade Calculation System\n-----------------------------------------------");

while (true)
{
    Student student = new Student();

    Console.Write("Enter Student Name: ");
    student.Name = Console.ReadLine();

    Console.Write("Enter Student ID: ");
    student.Id = Console.ReadLine();

    int subjectCount;
    while (true)
    {
        Console.Write("Enter the number of subject: ");
        if(int.TryParse(Console.ReadLine(), out subjectCount) && subjectCount > 0)
        {
            break;
        }
    }

    subjectCount = int.Parse(Console.ReadLine());
    student.Marks = new List<int>();
    for (int i = 0; i < subjectCount; i++)
    {
        Console.Write($"Enter the marks for subject {i + 1}: ");
        student.Marks.Add(int.Parse(Console.ReadLine()));
    }

    student.CalculateGrade();
    student.DisplayResult();
}