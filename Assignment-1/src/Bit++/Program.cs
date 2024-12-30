int n = int.Parse(Console.ReadLine());
if (n > 0 && n <= 150)
{
    int x = 0;
    for (int i = 0; i < n; i++)
    {
        string statement = Console.ReadLine();
        if (statement.Contains("X++") || statement.Contains("x++"))
            x++;
        else if (statement.Contains("++X") || statement.Contains("++x"))
            ++x;
        else if (statement.Contains("X--") || statement.Contains("x--"))
            x--;
        else
            --x;
    }
    Console.WriteLine(x);
}