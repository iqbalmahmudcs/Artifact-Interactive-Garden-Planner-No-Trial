////Arithmetic Operators
////Used for basic mathematical calculations.

//int addition = 3 + 2;   //Result = 5
//int subtraction	= 5 - 3;    //Result = 2
//int multiplication = 4 * 3;   //Result = 12
//double division = 10 / 2;  //Result = 5
//int modulus = 10 % 3;    //Result = 1






////2.Relational(Comparison) Operators
////Used to compare two values.

////Equal to Operation
//if (5 == 5)
//{
//    Console.WriteLine($"Result is True");
//}
//else
//{
//    Console.WriteLine($"Result is False");
//}

////Not equal to Operation
//if (5 != 3)
//{
//    Console.WriteLine($"Result is True");
//}
//else
//{
//    Console.WriteLine($"Result is False");
//}

////<	Less than Operation
//if (3 < 5)
//{
//    Console.WriteLine($"Result is True");
//}
//else
//{
//    Console.WriteLine($"Result is False");
//}

////>	Greater than Operation
//if (5 > 3)
//{
//    Console.WriteLine($"Result is True");
//}
//else
//{
//    Console.WriteLine($"Result is False");
//}

////<=	Less than or equal to Operation
//if (3 <= 3)
//{
//    Console.WriteLine($"Result is True");
//}
//else
//{
//    Console.WriteLine($"Result is False");
//}

////>=	Greater than or equal to Operation
//if (5 >= 5)
//{
//    Console.WriteLine($"Result is True");
//}
//else
//{
//    Console.WriteLine($"Result is False");
//}





////3.Logical Operators
////Used for logical operations, often in conditions.

////Logical AND Operation
//if ((5 == 5) && (4 < 5))
//{
//    Console.WriteLine($"Result is True");
//}
//else
//{
//    Console.WriteLine($"Result is False");
//}


////Logical OR Operation
//if ((5 == 5) || (4 > 5))
//{
//    Console.WriteLine($"Result is True");
//}
//else
//{
//    Console.WriteLine($"Result is False");
//}

////Logical NOT Operation
//if (4 !< 5)
//{
//    Console.WriteLine($"Result is True");
//}
//else
//{
//    Console.WriteLine($"Result is False");
//}






////4.Bitwise Operators
////Operate on binary representations of numbers.

//int bitwiseAND = 5 & 3;	//0101 & 0011 = 0001 or 1
//int bitwiseOR = 5 | 3;  //0101 | 0011 = 0111 or 7
//int bitwiseXOR = 5 ^ 3;  //0101 ^ 0011 = 1000 or 8
//int bitwiseComplement = ~5;    // ~0101 = -110 or -6
//int leftShift = 5 << 1;    // 0101 << 1 = 10 (1010)
//int rightShift = 5 >> 1;	//0101 << 1 = 2 (0010)






////5.Assignment Operators
////Used to assign values to variables.

//int assignOperator = 5;    //Assign Operator is "="

//int addAndAssign = 0;
//addAndAssign += 3;    //addAndAssign = addAndAssign + 3

//int subtractAndAssign = 0;
//subtractAndAssign -= 2;	//subtractAndAssign = subtractAndAssign - 2

//int multiplyAndAssign = 0;
//multiplyAndAssign *= 2; //multiplyAndAssign = multiplyAndAssign * 2

//int divideAndAssign = 0;
//divideAndAssign /= 2;    //x = x / 2

//int modulusAndAssign = 0;
//modulusAndAssign %= 2;    //	x = x % 2






////6.Unary Operators
////Operate on a single operand.


////int unaryPlus = -5;
////unaryPlus +;

////int unaryMinus = -5;
////unaryMinus -;


//int increment = 5;
//++increment;

//int decrement = 5;
//decrement--;
//--decrement;

//bool logicalNOT = !true;








/*Task: Create a Basic Calculator and Analyzer
You will build a program that:

Accepts two numbers from the user.
Performs arithmetic, relational, logical, and bitwise operations on these numbers.
Demonstrates unary, assignment, and miscellaneous operators.
Outputs all the results.*/

//Reading two numbers from user console

Console.Write("Please Enter First Number: ");
int number1 = int.Parse(Console.ReadLine());
Console.Write("Please Enter Second Number: ");
int number2 = int.Parse(Console.ReadLine());
Console.Write("Please enter a boolean value: ");
bool flag = bool.Parse(Console.ReadLine());

Console.WriteLine("\n--- Arithmetic Operations ---");
Console.WriteLine($"{number1} + {number2} = {number1 + number2}");
Console.WriteLine($"{number1} - {number2} = {number1 - number2}");
Console.WriteLine($"{number1} * {number2} = {number1 * number2}");
Console.WriteLine($"{number1} / {number2} = {(float)number1 / number2}");

Console.WriteLine("\n--- Relational Operations ---");
Console.WriteLine($"{number1} > {number2} = {number1 > number2}");
Console.WriteLine($"{number1} < {number2} = {number1 < number2}");
Console.WriteLine($"{number1} >= {number2} = {number1 >= number2}");
Console.WriteLine($"{number1} <= {number2} = {number1 <= number2}");
Console.WriteLine($"{number1} == {number2} = {number1 == number2}");
Console.WriteLine($"{number1} != {number2} = {number1 != number2}");

Console.WriteLine("\n--- Logical Operations ---");
Console.WriteLine($"{flag} && {(number1 > number2)} = {flag && (number1 > number2)}");
Console.WriteLine($"{flag} || {(number1 > number2)} = {flag || (number1 > number2)}");
Console.WriteLine($"!{flag} = {!flag}");

Console.WriteLine("\n--- Bitwise Operations ---");
Console.WriteLine($"{number1} & {number2} = {number1 & number2}");
Console.WriteLine($"{number1} | {number2} = {number1 | number2}");
Console.WriteLine($"{number1} ^ {number2} = {number1 ^ number2}");
if (number2 >= 0 && number2 < 32)
{
    Console.WriteLine($"{number1} << {number2} = {number1 << number2}");
    Console.WriteLine($"{number1} >> {number2} = {number1 >> number2}");
}
else
    Console.WriteLine("Shift value must be between 0 and 31.");


Console.WriteLine("\n--- Assignment Operations ---");
int temp = number1;
Console.WriteLine($"{temp} += {number2} = {temp += number2}");
Console.WriteLine($"{temp} -= {number2} = {temp -= number2}");
Console.WriteLine($"{temp} *= {number2} = {temp *= number2}");
if(number2 != 0)
{
    Console.WriteLine($"{temp} /= {number2} = {temp /= number2}");
    Console.WriteLine($"{temp} %= {number2} = {temp %= number2}");
}
else
{
    Console.WriteLine("Sorry! Zero value is not allowe for division and modulas operation!");
}

Console.WriteLine("\n--- Unary Operations ---");
Console.WriteLine($"++{number1} = {++temp}");
Console.WriteLine($"--{number1} = {--temp}");
Console.WriteLine($"-Unary {number1} = {-temp}");

Console.WriteLine("\n--- Miscellaneous Operations ---");
Console.WriteLine("\n--- Miscellaneous Operations ---");
Console.WriteLine($"Ternary: {number1} > {number2} ? \"{number1} is greater\" : \"{number2} is greater\" = {(number1 > number2 ? $"{number1} is greater" : $"{number2} is greater")}");

Console.WriteLine($"typeof({number1}) = {typeof(int)}");
Console.WriteLine($"flag is bool = {flag is bool}");
