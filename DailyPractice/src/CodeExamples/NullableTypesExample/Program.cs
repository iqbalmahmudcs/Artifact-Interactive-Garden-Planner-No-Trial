int? x = null;

int y;

if (int.TryParse(Console.ReadLine(), out y))
{
    Console.WriteLine("User Gave integer");
}

if (x.HasValue)
{
    Console.WriteLine(x.Value);
}

Nullable<int> t = null;    //not Recommenced

string s = "hello";

string s2 = s?.Substring(0, 2);

string s3 = s2 ?? "hello";    // If s2 == null then s3 = s2

s3 ??= s2;    // if s3 == null then s3 = s2 othewise s3 = s3