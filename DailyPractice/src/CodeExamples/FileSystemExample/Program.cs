using System.Runtime.CompilerServices;
using System.Text;

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

//Console.WriteLine(File.GetCreationTime(filename));
//Console.WriteLine(File.GetLastAccessTime(filename));

FileInfo fileInfo = new FileInfo(filename);

//File.GetAttributes(filename);
using FileStream fileStream = File.Open(filename, FileMode.Open);
byte[] buffer = new byte[10];
for (int i = 0; i < fileInfo.Length; i+=10)
{
    int total = fileStream.Read(buffer, 0, 10);
    string text = Encoding.UTF8.GetString(buffer);
    Console.Write(text);
}






