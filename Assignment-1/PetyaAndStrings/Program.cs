string input1 = Console.ReadLine().ToLower();
string input2 = Console.ReadLine().ToLower();

if(input1.Length == input2.Length)
{
    if (input1.Length > 0 && input1.Length <= 100 && input2.Length > 0 && input2.Length <= 100)
    {
        int result = 0;
        if(input1 == input2)
        {
            result = 0;
        }
        else if(input1.CompareTo(input2) < 0)
        {

            result = -1;
        }
        else
        {
            result = 1;
        }
        Console.WriteLine(result);
    }
}