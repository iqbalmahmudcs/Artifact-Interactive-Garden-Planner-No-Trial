int[,] matrix = new int[5,5];
int row = 0;
int column = 0;

for (int i = 0; i < 5; i++)
{
    string[] input = Console.ReadLine().Split();
    for (int j = 0; j < 5; j++)
    {
        matrix[i,j]= int.Parse(input[j]);
        if(matrix[i,j] == 1)
        {
            row = i + 1;
            column = j + 1;
        }
    }
}

int movesNeeded = Math.Abs(3 - row) + Math.Abs(3 - column);
Console.WriteLine(movesNeeded);