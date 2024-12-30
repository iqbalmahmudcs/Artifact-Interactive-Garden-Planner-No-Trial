int n = int.Parse(Console.ReadLine());
int count = 0;
if(n > 0 && n <= 1000)
{
    for (int i = 0; i < n; i++)
    {
        string[] input = Console.ReadLine().Split();
        int petya = int.Parse(input[0]);
        int vasy = int.Parse(input[1]);
        int tonya = int.Parse(input[2]);

        if (petya < 0 || petya > 1 || vasy < 0 || vasy > 1 || tonya < 0 || tonya > 1)
        {
        i--;
        continue;
        }
        else
        {
            if (petya + vasy + tonya >= 2)
            {
                count++;
            }
        }
    }
    Console.WriteLine(count);
}