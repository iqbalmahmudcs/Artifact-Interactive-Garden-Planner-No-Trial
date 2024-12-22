//For Loop

using System.Diagnostics.CodeAnalysis;

for (int i = 0;;i++)
{
    string line = Console.ReadLine();

    if (string.IsNullOrEmpty(line))
        break;
}


while (true)
{
    string line = Console.ReadLine();

    if (string.IsNullOrEmpty(line))
        break;

}

int[] arrays = {0, 1, 2, 3};
int sum = 0;
foreach (int i in arrays)
{
    sum += i;

}
Console.WriteLine($"{sum}");

