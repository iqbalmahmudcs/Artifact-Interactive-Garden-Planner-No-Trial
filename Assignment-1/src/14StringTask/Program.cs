string input = Console.ReadLine();

string vowels = "aoyeuiAOYEUI";
string result = "";

foreach (char ch in input)
{
    if (!vowels.Contains(ch))
    {
        result += "." + char.ToLower(ch);
    }
}

Console.WriteLine(result);
