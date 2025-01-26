string[] input = Console.ReadLine().Split();

int k = int.Parse(input[0]);
int n = int.Parse(input[1]);
int w = int.Parse(input[2]);

int totalCost =  k * (w * (w + 1) / 2);

int moneyNeeded = totalCost - n;

if(moneyNeeded < 0)
    moneyNeeded = 0;

Console.WriteLine(moneyNeeded);
