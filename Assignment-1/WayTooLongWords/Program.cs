using System;
using System.Diagnostics.Tracing;

int n = int.Parse(Console.ReadLine());

if(n > 0 && n <= 100)
{
    string[] words = new string[n];
    for (int i = 0; i < n; i++)
    {
        string temp = Console.ReadLine();
        if (temp.Length > 0 && temp.Length <=100) 
        {
            words[i] = temp;
        }
    }
    foreach (var word in words)
    {
        if (word.Length > 10)
            Console.WriteLine($"{word[0]}{word.Length - 2}{word[^1]}");
        else
            Console.WriteLine($"{word}");
    }

}