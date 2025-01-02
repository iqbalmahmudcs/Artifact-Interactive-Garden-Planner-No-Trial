using MethodOverLoadingExample;

Calculator calculator = new Calculator();


Console.WriteLine(calculator.Calculation(1, 2));
Console.WriteLine(calculator.Calculation(1, 2, 3));
Console.WriteLine($"{calculator.Calculation(1.1, 2.2):F1}");



Printer printer = new Printer();
Console.WriteLine(printer.Print("Iqbal"));
Console.WriteLine(printer.Print("Iqbal", "Hassan"));
Console.WriteLine(printer.Print("Iqbal", 26));