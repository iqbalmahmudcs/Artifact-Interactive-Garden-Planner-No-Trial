string s = Console.ReadLine();

if (s.Length < 1 || s.Length > 100)
    return;

int upperCaseCount = s.Count(char.IsUpper);
int lowerCaseCount = s.Count(char.IsLower);

string output = null;

if (upperCaseCount > lowerCaseCount)
    output = s.ToUpper();
else 
    output = s.ToLower();

Console.WriteLine(output);