(string Name, int Age) person = ("Jalaluddin", 20);

var anonymusType = new { person.Name, person.Age };

Console.WriteLine($"Name: {anonymusType.Name}, Age: {anonymusType.Age}");