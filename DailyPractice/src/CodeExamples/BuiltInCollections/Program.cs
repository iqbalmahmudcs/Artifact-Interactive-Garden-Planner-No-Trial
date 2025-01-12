//List
using System.Collections;

List<string> names = new List<string>();
names.Add("Iqbal");
names.Add("Hassan");

names.Capacity = 2;
names.Add("Mahmud");

Console.WriteLine(names);

foreach (string name in names)
{
    Console.WriteLine(name);
}


//W Linked List
LinkedList<string> list = new LinkedList<string>();

Dictionary<string, int> persons = new Dictionary<string, int>();
persons.Add("Iqbal", 26);
persons.Add("Hassan", 25);

persons["Hassan"] = 26;
Console.WriteLine(persons["Hassan"]);

Stack<string> stack = new Stack<string>();
stack.Push("Hello");
var item = stack.Pop();
Console.WriteLine(item);

Queue<string> queue = new Queue<string>();
queue.Enqueue("Queue");
var item2 = queue.Dequeue();
Console.WriteLine(item2);

SortedList<string, int> shortedList = new SortedList<string, int>();
shortedList.Add("Abdur Rahman", 1);
shortedList.Add("Abdullah", 21);
shortedList.Add("Mahmud", 24);

foreach(var name in shortedList)
    Console.WriteLine($"{name.Key}, {name.Value}");

HashSet<string> fruits = new HashSet<string>();
fruits.Add("Banana");
fruits.Add("Mango");
fruits.Add("Mango");
fruits.Add("Mango");
fruits.Add("Mango");
fruits.Add("Apple");
Console.WriteLine("++++++++++Fruits+++++++");
foreach(var fruit in fruits)
    Console.WriteLine(fruit);



// None Generic Keywords

ArrayList arrayList = new ArrayList();
arrayList.Add("Array");
arrayList.Add("List");
arrayList.Add(true);

//int x = (int)arrayList[0];
//Console.WriteLine(x);



Hashtable hashtable = new Hashtable();
hashtable.Add("Hash", 20);
hashtable.Add("Table", 11);




