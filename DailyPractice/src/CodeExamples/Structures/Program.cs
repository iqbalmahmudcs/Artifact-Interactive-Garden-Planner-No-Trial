using Structures;
Point p = new Point(3, 4);

Console.WriteLine($"X: {p.X}, Y: {p.Y}");
p.Display();

p.X = 10;
p.Y = 20;
p.Display();

Product p1 = new Product() { Name = "Camera", Price = 30000 };

Product p2 = p1;

p1.Name = "Laptop";
p1.Price = 50000;

Console.WriteLine($"P1 Name: {p1.Name} Price = {p1.Price}");
Console.WriteLine($"P2 Name: {p2.Name} Price = {p2.Price}");

