using Task2;

Student student1 = new Student();
Console.Write("Please Enter Student's First Name: ");
student1.FirstName = Console.ReadLine();
Console.Write("Please Enter Student's Last Name: ");
student1.LasttName = Console.ReadLine();
student1.DateOfBirth = new DateTime(1998, 04, 26);
student1.Grade = 80;
student1.DisplayDetails();
Console.WriteLine($"ID: {student1.GenerateId()}");

Console.WriteLine(); 
Teacher teacher1 = new Teacher();
Console.Write("Please Enter Teacher's First Name: ");
teacher1.FirstName = Console.ReadLine();
Console.Write("Please Enter Teacher's Last Name: ");
teacher1.LasttName = Console.ReadLine();
teacher1.DateOfBirth = new DateTime(1982, 05, 20);
Console.Write("Please Enter Department Name: ");
teacher1.Department = Console.ReadLine();
Console.Write("Please Enter Teacher's Subject Name: ");
teacher1.Subject = Console.ReadLine();
Console.WriteLine();
teacher1.DisplayDetails();
Console.WriteLine($"ID: {teacher1.GenerateId()}");