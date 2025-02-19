using AttendanceSystem;

Console.Write("Connection is checking");

for(int i = 0; i < 5; i++)
{
    Console.Write(".");
}
Console.WriteLine("\n");

DataUtility.TestDatabaseConnection();

