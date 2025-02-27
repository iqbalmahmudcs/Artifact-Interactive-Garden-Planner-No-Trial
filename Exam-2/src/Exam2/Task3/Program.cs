
void Calculate(int a, int b, out int average, out int max)
{
    if (a > b)
        max = a;
    else
        max = b;

    average = a + b / 2;
}