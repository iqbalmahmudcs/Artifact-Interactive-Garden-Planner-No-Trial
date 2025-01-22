using System.Runtime.CompilerServices;

var filename = "D:\\Devskill\\C# Professional Programming\\Coding\\csharpb19-IqbalHassanMahmud\\DailyPractice\\src\\CodeExamples\\FileSystemExample\\Hello.txt";

//if (!File.Exists(filename))
//{
//    File.Create(filename);
//    Console.WriteLine($"{filename} created.");
//}
//else
//    Console.WriteLine($"{filename} existed.");

//File.WriteAllText(filename, "This is from C#");
//File.AppendAllText(filename, "This is added");
//File.WriteAllLines(filename, ["Line-1", "Line-2", "Line-3"]);

Console.WriteLine(File.GetCreationTime(filename));
Console.WriteLine(File.GetLastAccessTime(filename));

FileInfo fileInfo = new FileInfo(filename);