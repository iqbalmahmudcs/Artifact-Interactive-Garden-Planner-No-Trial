
using Delegates;

Test.DoSomething t = Sum;

int Sum(int a, int b)
{
    return a + b;
}



BubbleSort<int> bubbleSort = new BubbleSort<int>();

var result = bubbleSort.Sort([3, 4, 1, 2, 8, 7], Check);


foreach(var i in result)
{
    Console.WriteLine(i);
}

bool Check(int a, int b)
{
    return a < b;
}

BubbleSort<Person> personSort = new BubbleSort<Person>();

List<Person> persons =
[
    new Person{Height = 7, Weight = 80},
    new Person{Height = 6, Weight = 70},
    new Person{Height = 6, Weight = 80},
];

var personResult =  personSort.Sort(persons.ToArray(), PersonCompare);

bool PersonCompare(Person a, Person b)
{
    if (a.Height == b.Height)
    {
        return a.Weight > b.Weight;
    }
    else
        return a.Height > b.Height;
}

foreach(var person in personResult)
{
    Console.WriteLine($"{person.Height}, {person.Weight}");
}