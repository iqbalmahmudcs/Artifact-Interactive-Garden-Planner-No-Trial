///*
//Tasks: 
//	=> Generating a 5GB Random Text File (33 Marks) 		
//	=> Generate a text file of exactly 5GB.	
//	=> Write random characters byte by byte (a method is already provided for this).	
//	=> Calculate the exact number of characters needed to reach 5GB.	
//	=> The generated file must be placed outside the project folder (alongside the solution file).	
//	=> Do not commit this file in the repository.	
//	=> If the file size is not exactly 5GB, you get zero marks.	
//*/

var directoryInformation = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.Parent.Parent.FullName;
var fileLocation = Path.Combine(directoryInformation, "RandomTextFile.txt");

long maximumFileSize = 5L * 1024 * 1024 * 1024;
long currentFileSize = 0;

int bufferSize = 1024 * 1024;
byte[] buffer = new byte[bufferSize];

Random random = new Random(DateTime.Now.Millisecond);

using (FileStream fileStream = new FileStream(fileLocation, FileMode.Create, FileAccess.Write, FileShare.None, bufferSize))
{
    while (currentFileSize < maximumFileSize)
    {
        for (int i = 0; i < bufferSize; i++)
        {
            buffer[i] = (byte)GetRandomChar(random);
        }
        
        long remainingBytes = maximumFileSize - currentFileSize;
        int bytesToWrite = (int)Math.Min(bufferSize, remainingBytes);
        
        fileStream.Write(buffer, 0, bytesToWrite);
        currentFileSize += bytesToWrite;

        if (currentFileSize % (500L * 1024 * 1024) == 0)
        {
            Console.WriteLine($"{currentFileSize / (1024 * 1024)} MB written.");
        }
    }
}

Console.WriteLine($"{currentFileSize / (1024 * 1024 * 1024)} GB File Generated Successfully.\nFile Location: {fileLocation}");

static char GetRandomChar(Random random) 
{
    return (char)random.Next('A', 'Z' + 1);
}