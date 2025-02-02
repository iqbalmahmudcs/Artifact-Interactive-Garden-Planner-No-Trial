/*Tasks
    => Locate the 5GB File generated in Task 1.
    => Set up the output directory inside the Task2 project folder.
    => Define constants:
        => Chunk size = 100MB
        => Max files per folder = 10
    => Read 100MB at a time and write into chunk files.
    => After every 10 files, create a new
*/


var directoryInformation = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.Parent.FullName;
var filePath = Path.Combine(directoryInformation, "RandomTextFile.txt");

if (!File.Exists(filePath))
{
    Console.WriteLine($"The random text file does not exist on {directoryInformation}. \nPlease Run the Task1 first...");
    return;
}

var folderLocation = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName;
var chunkFolder = Path.Combine(folderLocation, "Chunks");
Directory.CreateDirectory(chunkFolder);

long chunkSize = 100L * 1024 * 1024;
int filePerFolder = 10;
int chunkIndex = 1;
int folderIndex = 1;
long byteReadTotal = 0;

var currentFolder = Path.Combine(chunkFolder, $"Folder{folderIndex}");
Directory.CreateDirectory(currentFolder);

using (FileStream inputFileStream = new FileStream(filePath, FileMode.Open, FileAccess.Read))
{
    byte[] buffer = new byte[chunkSize];

    while (byteReadTotal < inputFileStream.Length)
    {
        int bytesRead = inputFileStream.Read(buffer, 0, buffer.Length);
        if (bytesRead == 0) break;

        var  chunkFilePath = Path.Combine(currentFolder, $"Chunk{chunkIndex}.txt");

        using (FileStream chunkFileStream = new FileStream(chunkFilePath, FileMode.Create, FileAccess.Write))
        {
            chunkFileStream.Write(buffer, 0, bytesRead);
        }

        byteReadTotal += bytesRead;
        Console.WriteLine($"Chunk{chunkIndex}.txt written ({bytesRead / (1024 * 1024)} MB)");

        if (chunkIndex % filePerFolder == 0)
        {
            folderIndex++;
            currentFolder = Path.Combine(chunkFolder, $"Folder{folderIndex}");
            Directory.CreateDirectory(currentFolder);
        }

        chunkIndex++;
    }
}

Console.WriteLine("\nFile Splitting Complete!");
Console.WriteLine($"All chunks are saved in: {chunkFolder}");
