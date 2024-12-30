string[] input = Console.ReadLine().Split();
int n = int.Parse(input[0]);
int k = int.Parse(input[1]);

if(k > 0 && n >= k && k <= 50 && n <= 50)
{
    int nextRound = 0;
    int[] scores = new int[n];
    input =  Console.ReadLine().Split();
    for(int i = 0; i < input.Length; i++)
    {
        scores[i]= int.Parse(input[i]);
    }
    int kthScore = scores[k-1];
    for(int i = 0;i < scores.Length; i++)
    {
        if(scores[i] >= kthScore && scores[i] > 0)
            nextRound++;
    }
    Console.WriteLine(nextRound);
}