int input = int.Parse(Console.ReadLine());

if (input < 1 || input > 1000000)
    return;

int stepsCount = input / 5;

if (input % 5 != 0)
    stepsCount += 1;


Console.WriteLine(stepsCount);