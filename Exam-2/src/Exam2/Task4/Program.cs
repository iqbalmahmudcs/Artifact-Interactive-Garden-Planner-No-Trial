using Task4;

Converter converter = new Converter();

string input = "This is Case Converter solution";
string output = converter.ReplaceCase(input);

Console.WriteLine($"Original Text: {input}");
Console.WriteLine($"Converted Text: {output}");
