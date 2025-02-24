using Exam_2;
using System.Text;

#region Student
/*
Student student1 = new Student("Iqbal", 26, 3.85);

student1.Display();
*/
#endregion

#region Rectangle
/*
Rectangle rectancge1 = new Rectangle(10.5, 5.2);

rectancge1.Display();
*/
#endregion

#region DaysOfWeek
/*
DayOfWeek today = DayOfWeek.Sunday;

Console.WriteLine(today);

*/
#endregion

#region DaysOfWeek
/*

TrafficLight signal1 = TrafficLight.Red;
TrafficLight signal2 = TrafficLight.Yellow;
TrafficLight signal3 = TrafficLight.Green;

Console.Write("Red: ");
DisplaySignal(signal1);

Console.Write("Yellow: ");
DisplaySignal(signal2);

Console.Write("Green: ");
DisplaySignal(signal3);

Console.WriteLine("\nPress Enter to exit...");
Console.ReadLine();

static void DisplaySignal(TrafficLight light)
{
    switch (light)
    {
        case TrafficLight.Red:
            Console.WriteLine("Stop");
            break;
        case TrafficLight.Yellow:
            Console.WriteLine("Get Ready");
            break;
        case TrafficLight.Green:
            Console.WriteLine("Go");
            break;
        default:
            Console.WriteLine("Invalid Signal");
            break;
    }
}

*/
#endregion

#region DateTime
/*
DateTime now = DateTime.Now;
Console.WriteLine($"current Date and Time Now: {now}");

DateTime nowUtc = DateTime.UtcNow;
Console.WriteLine($"current Date and Time UtcNow: {nowUtc}");

DateTime today = DateTime.Today;
Console.WriteLine($"current Date and Time Today: {today}");

*/
#endregion


#region DateTimeTask
/*
DateTime current = DateTime.Now;
int year = DateTime.Now.Year;
int month = DateTime.Now.Month;
int day = DateTime.Now.Day;
String weekday = DateTime.Now.DayOfWeek.ToString();

Console.WriteLine($"Date Time Now: {current}");
Console.WriteLine($"Date Time Year: {year}");
Console.WriteLine($"Date Time Month: {month}");
Console.WriteLine($"Date Time Day: {day}");
Console.WriteLine($"Date Time Week Day: {weekday}");
Console.WriteLine($"Date Time as (dd-MM-yyyy): {current.ToString("dd-MM-yyyy")}");
Console.WriteLine($"Date Time as (MMMM dd, yyyy): {current.ToString("MMMM dd, yyyy")}");
Console.WriteLine($"Date Time after 7 days: {current.AddDays(7)}");

*/
#endregion


#region StringBuilder
/*
StringBuilder sb = new StringBuilder("Hello");

sb.Append(" World!");
sb.AppendLine(" Welcome to C#");
sb.Insert(0, "Grettings, ");
sb.Replace("#", " Sharp");
 
Console.WriteLine(sb);


*/
#endregion


#region StringBuilder
//*
StringBuilder stringBuilder = new StringBuilder("C# is great!");
stringBuilder.Append(" It's powerfull and efficient.");
stringBuilder.Insert(5, "very ");
stringBuilder.Replace("great", "awesome");
stringBuilder.Remove("efficient"); 

Console.WriteLine(stringBuilder);


//*/
#endregion
