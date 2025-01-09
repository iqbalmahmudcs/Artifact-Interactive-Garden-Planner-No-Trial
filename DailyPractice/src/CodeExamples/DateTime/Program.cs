DateTime date = new DateTime(2023, 3, 10, 12, 50, 20);
Console.WriteLine(date);

Console.WriteLine(DateTime.Now);

DateTime after100Day = DateTime.Now.AddDays(365);

Console.WriteLine(after100Day);

Console.WriteLine(DateTime.IsLeapYear(2029));