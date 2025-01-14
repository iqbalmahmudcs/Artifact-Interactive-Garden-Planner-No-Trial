string[] input = Console.ReadLine().Split();
int a = int.Parse(input[0]); 
int b = int.Parse(input[1]);

if (a < 1 || b < 1 || b < a || a > 10 || b > 10)
    return;

int year = 0;

while (a <= b)
{
    a *= 3;
    b *= 2;
    year++;
}

Console.WriteLine(year);


