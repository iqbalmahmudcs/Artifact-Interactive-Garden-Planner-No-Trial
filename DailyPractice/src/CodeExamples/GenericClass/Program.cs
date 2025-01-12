using GenericClass;

var result = new BubbleSort<int>().Sort([11, 55, 33, 44, 22]);

foreach (var item in result)
    Console.WriteLine(item);