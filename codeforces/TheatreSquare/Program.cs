string[] input = Console.ReadLine().Split();
long n = long.Parse(input[0]);
long m = long.Parse(input[1]);
long a = long.Parse(input[2]);

if (n > 0 && m > 0 && a > 0 || n <= 1000000000 && m <= 1000000000 && a <= 1000000000)
{
    long flagStoneLength = (n + a - 1) / a;
    long flagStoneWidth = (m + a - 1) / a;
    long numberOfFlagStone = flagStoneLength * flagStoneWidth;
    Console.WriteLine(numberOfFlagStone);
}
