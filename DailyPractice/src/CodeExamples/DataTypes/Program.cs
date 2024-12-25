// Value Types: Store data directly (e.g., int, float, bool).
// Reference Types: Store references to the data's memory location (e.g., string, arrays, objects).

// Declaring variables
byte byteValue = 255;               // 8-bit unsigned integer, Range: 0 to 255
sbyte sByteValue = -128;            // 8-bit signed integer, Range: -128 to 127

short shortValue = -32768;          // 16-bit signed integer, Range: -32,768 to 32,767
ushort uShortValue = 65535;         // 16-bit unsigned integer, Range: 0 to 65,535

int intValue = -2147483648;         // 32-bit signed integer, Range: -2,147,483,648 to 2,147,483,647
uint uIntValue = 4294967295;        // 32-bit unsigned integer, Range: 0 to 4,294,967,295

long longValue = -9223372036854775808;  // 64-bit signed integer, Range: -9,223,372,036,854,775,808 to 9,223,372,036,854,775,807
ulong uLongValue = 18446744073709551615; // 64-bit unsigned integer, Range: 0 to 18,446,744,073,709,551,615

float floatValue = -3.402823e38f;   // 32-bit floating point, Range: ±1.5 x 10^-45 to ±3.4 x 10^38
double doubleValue = -1.79769313486232e307;  // 64-bit double-precision, Range: ±5.0 x 10^-324 to ±1.7 x 10^308
decimal decimalValue = 1.9438593587394539746384535035987458m;  // 128-bit, Range: ±1.0 x 10^-28 to ±7.9 x 10^28

char charValue = 'A';               // Single Unicode character, e.g., 'A', '*', '\x0058', or '\u0058'

bool boolValue = true;              // Logical value: true or false

object objectValue = "Any data type"; // Base type of all types, Range: all types
string stringValue = "Text";        // Sequence of Unicode characters, Range: N/A

DateTime dateTimeValue = DateTime.Now; // Range: 0:00:00 AM 1/1/01 to 11:59:59 PM 12/31/9999

// Printing the values to the console
Console.WriteLine($"=> Byte: 0 to {byteValue}");
Console.WriteLine($"=> SByte: {sByteValue} to 127");

Console.WriteLine($"\n=> Short: {shortValue} to 32,767");
Console.WriteLine($"=> UShort: 0 to {uShortValue}");

Console.WriteLine($"\n=> Int: {intValue} to 2,147,483,647");
Console.WriteLine($"=> UInt: 0 to {uIntValue}");

Console.WriteLine($"\n=> Long: {longValue} to 9,223,372,036,854,775,807");
Console.WriteLine($"=> ULong: 0 to {uLongValue}");

Console.WriteLine($"\n=> Float: {floatValue} to 3.402823e38");
Console.WriteLine($"=> Double: {doubleValue}");
Console.WriteLine($"=> Decimal: {decimalValue}");

Console.WriteLine($"\n=> Char: {charValue}");
Console.WriteLine($"=> Bool: {boolValue}");

Console.WriteLine($"\n=> Object: {objectValue}");
Console.WriteLine($"=> String: {stringValue}");

Console.WriteLine($"\n=> DateTime: {dateTimeValue}");
