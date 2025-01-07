string input = Console.ReadLine();

if (string.IsNullOrEmpty(input) || input.Length > 1000)
    return;

string output = char.ToUpper(input[0]) + input.Substring(1);

Console.WriteLine(output);