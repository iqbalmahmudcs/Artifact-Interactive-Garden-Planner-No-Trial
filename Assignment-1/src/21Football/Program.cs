string players = Console.ReadLine();

if (string.IsNullOrEmpty(players) || players.Length > 100)
    return;

if (players.Contains("0000000") || players.Contains("1111111"))
    Console.WriteLine("YES");
else
    Console.WriteLine("NO");
