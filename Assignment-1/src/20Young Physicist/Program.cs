int n = int.Parse(Console.ReadLine());

int sumX = 0, sumY = 0, sumZ = 0;

for(int i = 0; i < n; i++)
{
    string[] input = Console.ReadLine().Split();

    int x = int.Parse(input[0]);
    int y = int.Parse(input[1]);
    int z = int.Parse(input[2]);

    sumX += x;
    sumY += y;
    sumZ += z;
}

//if(sumX == 0 && sumY ==0 && sumZ == 0)
//    Console.WriteLine("YES");
//else
//    Console.WriteLine("NO");

Console.WriteLine((sumX == 0 && sumY == 0 && sumZ == 0) ? "YES" : "NO");