string n = Console.ReadLine();

int luckyCount = 0;

foreach (char c in n)
{
    if (c == '4' || c == '7')
        luckyCount++;
}

string luckyCountStr = luckyCount.ToString();
bool isNearlyLucky = true;

foreach (char c in luckyCountStr)
{
    if (c != '4' && c != '7')
    {
        isNearlyLucky = false;
        break;
    }
}

Console.WriteLine(isNearlyLucky ? "YES" : "NO");