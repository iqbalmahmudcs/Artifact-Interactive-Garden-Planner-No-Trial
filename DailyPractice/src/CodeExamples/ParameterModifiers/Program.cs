using ParameterModifiers;

Console.WriteLine(Demo.Average(1, 2, 3, 4, 5));

int a = 50;

Demo.Test1(ref a);
Console.WriteLine();

int b = 50;
Demo.Test3(out b);
Console.WriteLine(b);