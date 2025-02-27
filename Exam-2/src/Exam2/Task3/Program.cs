int average, max;
Calculate(8, 12, out average, out max);
Console.WriteLine($"Average: {average}, Max: {max}");

void Calculate(int a, int b, out int average, out int max)
{
    if (a > b)
        max = a;
    else
        max = b;

    average = (a + b) / 2;
}

