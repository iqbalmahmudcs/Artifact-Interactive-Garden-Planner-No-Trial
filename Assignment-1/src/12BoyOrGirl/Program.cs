string input = Console.ReadLine().ToLower();

if (string.IsNullOrEmpty(input) | input.Length > 100)
{
    return;
}
if(input.Distinct().Count() % 2 == 0)
{
    Console.WriteLine("CHAT WITH HER!");
}
else
    Console.WriteLine("IGNORE HIM!");
