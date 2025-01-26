int n = int.Parse(Console.ReadLine());

if (n < 1 && n > 50)
    return;

string input = Console.ReadLine();

if (input == null) return;
if (input.Length > n) return;

int count = 0;     // count of the number of stones to be removed.

for (int i = 1; i < n; i++)
{
    if (input[i] == input[i - 1])
    {
        count++;
    }
}
Console.WriteLine(count);