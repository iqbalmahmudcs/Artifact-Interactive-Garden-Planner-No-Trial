using StringManipulationWithOverloadedMethods;

StringManipulator stringmanupulator = new StringManipulator();

Console.WriteLine($"Reversed String: {stringmanupulator.StringManipulate("iqbal")}");
Console.WriteLine($"Concatenated String: {stringmanupulator.StringManipulate("Welcome to", "C#")}");
Console.WriteLine($"Length of String: {stringmanupulator.GateLenth("iqbal")}");
Console.WriteLine($"Count of 'e': {stringmanupulator.StringManipulate("iqbal", 'e')}");
