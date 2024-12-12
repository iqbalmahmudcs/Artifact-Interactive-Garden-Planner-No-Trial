////Single Dimensional Array
//int[] numbers = { 10, 20, 30, 40, 50 };
//foreach (int num in numbers)
//{
//    Console.WriteLine(num);
//}



////Multi Dimensional Array
//int[,] matrix = { { 1, 2, 3 }, { 4, 5, 6 } };
//for (int i = 0; i < matrix.GetLength(0); i++)
//{
//    for (int j = 0; j < matrix.GetLength(1); j++)
//    {
//        Console.Write(matrix[i, j] + " ");
//    }
//    Console.WriteLine();
//}




////Jagged Array
////Declaration and Initialization:
//int[][] jaggedArray = new int[3][];
//jaggedArray[0] = new int[] { 1, 2, 3 };   // First row has 3 elements
//jaggedArray[1] = new int[] { 4, 5 };      // Second row has 2 elements
//jaggedArray[2] = new int[] { 6, 7, 8, 9 }; // Third row has 4 elements

////Accessing Elements:
//Console.WriteLine(jaggedArray[0][1]); // Prints 2 (Second element of first row)
//Console.WriteLine(jaggedArray[1][0]); // Prints 4 (First element of second row)

////Iterating Through Jagged Array
//foreach (var row in jaggedArray)
//{
//    foreach (var item in row)
//    {
//        Console.Write(item + " ");
//    }
//    Console.WriteLine();
//}






////Read an array X[10]. After, replace every null or negative v of X ​by 1. Print all numbers stored in the array X.
//try
//{
//    //Declaring an array
//    Console.Write("Please declare your array size: ");
//    int arraySize = int.Parse(Console.ReadLine());
//    if (arraySize <= 0)
//    {
//        Console.WriteLine("Array size must be greater than 0.");
//    }
//    int[] x = new int[arraySize];

//    //Getting input & replacing every null or negative v with 1
//    Console.WriteLine($"Please enter {arraySize} v which may positive / negative / null value: ");
//    for (int i = 0; i < x.Length; i++)
//    {
//        //x[i] = int.Parse(Console.ReadLine());
//        //input validation 
//        bool isValid = int.TryParse(Console.ReadLine(), out x[i]);
//        if (!isValid)
//        {
//            Console.WriteLine("Invalid input. Please enter a valid integer v it may including positive / negative / null value.");
//            i--;
//            continue;
//        }
//        if (x[i] <= 0)
//        {
//            Console.WriteLine($"Invalid value at index {i}. Replacing with 1.");
//            x[i] = 1;
//        }
//    }

//    //Getting output
//    Console.WriteLine("The Final Array is: ");
//    for (int i = 0; i < x.Length; i++)
//    {
//        Console.WriteLine($"x[{i}] = {x[i]}");
//    }
//}
//catch (Exception ex)
//{
//    Console.WriteLine($"An error occcurred. {ex.Message}");
//}










////Q: Read a v and make a program which puts this v in the first position of an array N[10].
////In each subsequent position, put the double of the previous position.
////For example, if the input v is 1, the array numbers ​​must be 1,2,4,8, and so on.

//int v = int.Parse(Console.ReadLine());

//if (v < 50)
//{
//    int[] x = new int[10];
//    x[0] = v;

//    for (int i = 1; i < x.Length; i++)
//    {
//        x[i] = x[i - 1] * 2;
//    }

//    for (int i = 0; i < x.Length; i++)
//    {
//        Console.WriteLine($"N[{i}] = {x[i]}");
//    }
//}
//else
//{
//    Console.WriteLine("The input is must less than 50).");
//}













//In this problem, your task is to read an array A[100].
//At the end, print all array positions that store a number less or equal to 10 and the number stored in that position.
//Input: The input contains 100 numbers. Each number can be integer, floating-point number, positive or negative.
//Output: For each number of the array that is equal to 10 or less, print "A [i] = x", where i is the position of the array and x is the number stored in the position, with one digit after the decimal point.

double[] a = new double[100];

for (int i = 0; i < a.Length; i++)
{
    a[i] = double.Parse(Console.ReadLine());
}

for (int i = 0; i < a.Length; i++)
{
    if (a[i] <= 10)
    {
        Console.WriteLine($"A[{i}] = {a[i]:F1}");
    }
}
