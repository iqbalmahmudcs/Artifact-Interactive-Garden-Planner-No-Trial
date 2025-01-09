using Enums;

//You can refer to an enum value by its name:
DaysOfWeek today = DaysOfWeek.Monday;
Console.WriteLine(today);


//Enums can be converted to their underlying integer values:
int dayValue = (int)DaysOfWeek.Monday;
Console.WriteLine(dayValue);


//You can also cast an integer to an enum type:
DaysOfWeek day = (DaysOfWeek)2;
Console.WriteLine(day);


//Using Enums in Conditions
switch (today)
{
    case DaysOfWeek.Sunday:
        Console.WriteLine($"{(int)DaysOfWeek.Sunday}");
        break;
    case DaysOfWeek.Monday:
        Console.WriteLine($"{(int)DaysOfWeek.Monday}");
        break;
    case DaysOfWeek.Tuesday:
        Console.WriteLine($"{(int)DaysOfWeek.Tuesday}");
        break;
    case DaysOfWeek.Thursday:
        Console.WriteLine($"{(int)DaysOfWeek.Thursday}");
        break;
    case DaysOfWeek.Friday:
        Console.WriteLine($"{(int)DaysOfWeek.Friday}");
        break;
    case DaysOfWeek.Saturday:
        Console.WriteLine($"{(int)DaysOfWeek.Saturday}");
        break;
}


//Enums can be combined with the [Flags] attribute to represent a combination of options:
System.IO.FileAccess access = System.IO.FileAccess.Read | System.IO.FileAccess.Write;

if (access.HasFlag(System.IO.FileAccess.Read))
{
    Console.WriteLine("Red access granted.");
}



//Enums can be converted to their string representation:
Console.WriteLine(DaysOfWeek.Friday.ToString());



//You can parse a string into an enum:
DaysOfWeek parsedDay = (DaysOfWeek)Enum.Parse(typeof(DaysOfWeek), "Tuesday");
Console.WriteLine(parsedDay);



OrderStatus status = OrderStatus.Processing;


Fruits fruits = Fruits.Banana;

if (status == OrderStatus.Pending)
{
    Console.WriteLine("Pending");
}
else if (status == OrderStatus.Accepted)
{
    Console.WriteLine("Accepted");
}
else if (status == OrderStatus.Processing)
{
    Console.WriteLine();
}