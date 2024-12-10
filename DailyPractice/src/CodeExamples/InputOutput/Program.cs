//Console.WriteLine("Hello, World!");
//Console.Write("Hello");
//Console.Write("World!");
//Console.WriteLine();



////Console.ReadLine();
//string stringWord = Console.ReadLine();

////Console.Read();
//char c = (char)Console.Read();

////Console.ReadKey();
//ConsoleKeyInfo key = Console.ReadKey(true); // Key press won't be displayed


////Console.WriteLine($"String Word = {stringWord}.\nCharecter C = {c}.\n Key = {key.Key}");
//string output = $"String Word = {stringWord}.\nCharecter C = {c}.\n Key = {key.Key}";
//Console.WriteLine(output);



string line = Console.ReadLine();
string[] lineParts = line.Split(' ', ',');
int number = int.Parse(lineParts[0]);
bool bollian = bool.Parse(lineParts[1]);

Console.WriteLine($"number = {number}\nBoolian = {bollian}");


