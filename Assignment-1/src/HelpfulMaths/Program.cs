string s = Console.ReadLine();

if (s.Length > 100)
    return;

if (!s.All(c => c == '+' || c == '1' || c == '2' || c == '3'))
    return;

string[] numbers = s.Split('+');
int[] shortedNumber = Array.ConvertAll(numbers, int.Parse);
Array.Sort(shortedNumber);

string result = string.Join("+", shortedNumber);

Console.WriteLine(result);
