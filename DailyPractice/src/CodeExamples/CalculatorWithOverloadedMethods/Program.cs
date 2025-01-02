using CalculatorWithOverloadedMethods;

Calculator calculator = new Calculator();

Console.WriteLine($"Addition of Two Int: {calculator.Addition(1, 2)}");
Console.WriteLine($"Addition of Three Int: {calculator.Addition(1, 2, 3)}");
Console.WriteLine($"Addition of Two double: {calculator.Addition(1.1, 2.2):F2}");
Console.WriteLine($"Multiplication of Two Int: {calculator.Multiplication(1, 2)}");
Console.WriteLine($"Multiplication of Three Int: {calculator.Multiplication(1, 2, 3)}");
Console.WriteLine($"Multiplication of Two double: {calculator.Multiplication(1.1, 2.2):F2}");