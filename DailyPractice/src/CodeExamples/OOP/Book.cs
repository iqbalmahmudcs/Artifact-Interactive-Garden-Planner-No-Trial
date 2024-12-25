using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    public class Book
    {
        public string Title {get; set;}
        public string Author {get; set;}

        public void DisplayDetails()
        {
            Console.WriteLine($"Title: {Title}\nAuthor: {Author}");
        }

    }
}
