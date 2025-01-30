/*
Task 1: 
	=> Generating a 5GB Random Text File (33 Marks) 		
	=> Generate a text file of exactly 5GB.	
	=> Write random characters byte by byte (a method is already provided for this).	
	=> Calculate the exact number of characters needed to reach 5GB.	
	=> The generated file must be placed outside the project folder (alongside the solution file).	
	=> Do not commit this file in the repository.	
	=> If the file size is not exactly 5GB, you get zero marks.	
*/

using System.Text;
using System.Xml;



//var fileLocation = Directory.GetCurrentDirectory();
//DirectoryInfo directoryInfo = new DirectoryInfo(fileLocation);
//fileLocation = directoryInfo.Parent.Parent.Parent.Parent.Parent.Parent.FullName + "5GbRandomTextFile.txt";

var directoryInfo = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.Parent.Parent.FullName;
var fileLocation = Path.Combine(directoryInfo, "5GB_RandomTextFile.txt");


long maxFileSize = 5L * 1024 * 1024 * 1024;
long currentFileSize = 0;

using (FileStream fileStream = new FileStream(fileLocation, FileMode.Create, FileAccess.Write))
using(StreamWriter fileWriter = new StreamWriter(fileStream, Encoding.UTF8))
{
	Random random = new Random(DateTime.Now.Millisecond);

	while ( currentFileSize < maxFileSize)
	{
        char randomCharecter = GetRandomChar(random);
        byte[] characterBytes = Encoding.UTF8.GetBytes(random.ToString());

        fileWriter.BaseStream.Write(characterBytes, 0, characterBytes.Length);
        currentFileSize += characterBytes.Length;

        //  if (currentFileSize % (1024 * 1024 * 100) == 0)
        //Console.WriteLine($"{currentFileSize / (1024 * 1024)} MB Written Succesfully.");
    }
}

Console.WriteLine($"{maxFileSize / (1024 * 1024 * 1024)} GB File Generated at {fileLocation}");


char GetRandomChar(Random random)
{
    return (char)random.Next('A', 'Z');
}
