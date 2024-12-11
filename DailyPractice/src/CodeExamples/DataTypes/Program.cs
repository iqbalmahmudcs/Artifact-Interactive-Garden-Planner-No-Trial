//Value Types: Store data directly (e.g., int, float, bool).
//Reference Types: Store references to the data's memory location (e.g., string, arrays, objects).

//Declaring variables
byte byteValue = 255;    //Accepts 8-bit unsigned integer    Range: 0 to 255
sbyte sByteValue = -128;    //Accepts 8-bit signed integer    Range: -128 to 127.

short shortValue = -32768;    //Accepts 16-bit signed integer    Range: -32,768 to 32,767
ushort ushoertValue = 65535;    //Accepts 16-bit unsigned integer Range: 0 to 65,535

int intValue = -2147483648;    //Accepts 32-bit signed integer    Range: -2,147,483,648 to 2,147,483,647
uint uIntValue = 4294967295;    //Accepts 32-bit unsigned integer    Range: 0 to 4,294,967,295

long longValue = -9223372036854775808;    //Accepts 64-bit signed integer     Range: -9,223,372,036,854,775,808 to 9,223,372,036,854,775,807
ulong uLongValue = 18446744073709551615;    //Accepts 64-bit unsigned integer    Range 0 to 18,446,744,073,709,551,615

float floatValue = -3.402823e38f;    //Accepts 32-bit Single-precision floating point type    Range: -3.402823e38 to 3.402823e38
double doubleValue = -1.797693134862320308;    //Accepts 64-bit double-precision floating point type    Range: -1.79769313486232e308 to 1.79769313486232e308
decimal decimalValue = 1.9438593587394539746384535035987458m;    //Accepts 128-bit decimal type for financial and monetary calculations    Range: (+ or -)1.0 x 10e-28 to 7.9 x 10e28

char charValue = 'A';    //Accepts 16-bit single Unicode character    Range: Any valid character, e.g. a,*, \x0058 (hex), or\u0058 (Unicode)

bool boolValue = true;    //Accepts 8-bit logical true/false value    Range: True / False

object objectValue = "all Types od data can hold";    //It is Base type of all other types.    Range: all types of data
string stringValue = "not mentioned";     //Accepts A sequence of Unicode characters.    Range N/A

DateTime dateTimeValue = DateTime.Now;    //Accepts 0:00:00am 1/1/01 to 11:59:59pm 12/31/9999


//Printing the values to the console.
Console.WriteLine($"This is Byte Type Data. It Accepts 8-bit unsigned integer and Range is: 0 to {byteValue}.");
Console.WriteLine($"This is Signed Byte Type Data. It Accepts 8-bit signed integer and Range is: {sByteValue} to 127.");

Console.WriteLine();
Console.WriteLine($"This is Signed Short Type Data. It Accepts 16-bit signed integer and Range is: {shortValue} to 32,767.");
Console.WriteLine($"This is Unsigned Short Type Data. It Accepts 16-bit signed integer and Range is: 0 to {ushoertValue}.");

Console.WriteLine();
Console.WriteLine($"This is Signed Integer Type Data. It Accepts 32-bit signed integer and Range is: {intValue} to 2,147,483,647.");
Console.WriteLine($"This is Unsigned Integer Type Data. It Accepts 32-bit signed integer and Range is: 0 to {uIntValue}.");

Console.WriteLine();
Console.WriteLine($"This is Signed Integer(Long) Type Data. It Accepts 64-bit signed integer and Range is: {longValue} to 2,147,483,647.");
Console.WriteLine($"This is Unsigned Integer(Long) Type Data. It Accepts 64-bit signed integer and Range is: 0 to {uLongValue}.");

Console.WriteLine();
Console.WriteLine($"This is Signed Float Type Data. It Accepts 32-bit Single-precision floating point type and Range is: {floatValue} to 3.402823e38");
Console.WriteLine($"This is Unsigned Double Type Data. It Accepts 64-bit double-precision floating point type and Range is:  -1.79769313486232e308 to 1.79769313486232e308. Present Value is: {decimalValue}");
Console.WriteLine($"This is Unsigned Decimal Type Data. It Accepts 128-bit decimal type for financial and monetary calculations and Range is: (+ or -)1.0 x 10e-28 to 7.9 x 10e28. Present Value is: {decimalValue}");

Console.WriteLine();
Console.WriteLine($"This is Character Type Data. It Accepts 16-bit single Unicode character and Range is: Any valid character, e.g. a,*, \x0058 (hex), or\u0058 (Unicode). Present Value is: {charValue}.");

Console.WriteLine();
Console.WriteLine($"This is Boolean Type Data. It accepts 8-bit logical true/false value and Range is: {boolValue} / False.");

Console.WriteLine();
Console.WriteLine($"This is Object Data Type. It  is Base type of all other types and Range is: {objectValue}.");
Console.WriteLine($"This is String Data Type. It Accepts A sequence of Unicode characters and Range is {stringValue}.");

Console.WriteLine();
Console.WriteLine($"This is Date-Time Data Type. It Accepts 0:00:00am 1/1/01 to 11:59:59pm 12/31/9999. It is: {dateTimeValue} now.");






