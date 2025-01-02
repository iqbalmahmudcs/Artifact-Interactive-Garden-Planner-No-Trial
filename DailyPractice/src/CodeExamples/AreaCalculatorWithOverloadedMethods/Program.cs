using AreaCalculatorWithOverloadedMethods;

AreaCalculator areaCalculator = new AreaCalculator();

Console.WriteLine($"Area of Circle: {areaCalculator.CalculateArea(1.1):F2}");
Console.WriteLine($"Area of Rectangle: {areaCalculator.CalculateArea(1,2)}");
Console.WriteLine($"Area of Triangle: {areaCalculator.CalculateArea(1,2):F2}");