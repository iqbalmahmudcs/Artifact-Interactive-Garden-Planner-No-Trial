int age = int.Parse(Console.ReadLine());

if (age >= 18 && age <= 50)
{
    Console.WriteLine("Ok");
}
else if (age >50)
{
    Console.WriteLine("Old");
}
else if (age > 12 && age < 18)
{
    Console.WriteLine("Younger");
}
else
{
    Console.WriteLine("Child");
}

