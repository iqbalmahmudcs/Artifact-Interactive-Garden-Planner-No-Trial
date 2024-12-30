string[] input = Console.ReadLine().Split();
int m = int.Parse(input[0]);
int n = int.Parse(input[1]);

if(m > 0 && m < 17 && n > 0 && n < 17)
{
    int areaOfBoard = n * m;
    int areaOfDomino = 2 * 1;

    int numberOfDominoPlaced = areaOfBoard / areaOfDomino;

    Console.WriteLine(numberOfDominoPlaced);
}