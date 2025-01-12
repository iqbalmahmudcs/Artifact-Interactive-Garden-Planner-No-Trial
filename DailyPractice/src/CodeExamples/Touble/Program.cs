int x = 5;
string y = "Hello";

(int x, string y) something = (5, "Hello");    //touple
Console.WriteLine($"{something.x} {something.y}");

(double, bool) t = (5.5, true);    //touple
Console.WriteLine($"{t.Item1} {t.Item2}");

(int, int) Calculate((double, double) x, (int, int) y)
{
    return ((int)x.Item1 +y.Item2, (int)x.Item2 +y.Item1);
}
