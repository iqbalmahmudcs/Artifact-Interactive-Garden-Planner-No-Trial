using OOP;

//01. Classes and Objects
//creating an object
Car car = new Car { Brand = "Toyota", Speed = 100};
car.Drive();

//02. Encapsulation
BankAccount account = new BankAccount();
account.Deposit(200);
Console.WriteLine($"Current Balance: {account.GetBalance()}");

//03. Inheritance
Dog dog = new Dog();
dog.Eat();
dog.Bark();

//04. Polymorphism
Shape shape = new Circle();
shape.Draw();

//Overloaded method in shape
shape.Draw("Red");
shape.Draw(5);

//Accessing Circle-Specific Overloading
Circle circle = new Circle();
circle.Draw("Blue", 7.5);

//05. Abstraction
//using abstract class reference
Vehicle vehicle = new Bicycle();
vehicle.Move();

//using interface reference
IOperable operable = new Bicycle();
operable.Start();


//Working on Book Class
Book book = new Book();
book.Title = "The Holy Quran";
book.Author = "Allah";
book.DisplayDetails();


