using System.Text;

StringBuilder text = new StringBuilder("Basic");

text.Append(" Text")
    .Append(" for C#")
    .Replace("#", "Sharp");
Console.WriteLine( text);
