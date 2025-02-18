using System.Threading.Tasks;

/*
[Note: Due to personal problems and the official workload, I couldn't complete Task 3. I finished it on February 17-18th. While working on Task 3, I had to change the folder location of Task 2.
*/

/*Tasks
    => Locating the chunks generated in Task 2.
    => Merging all the chunks back into a single file.
    => Merging in reverse order (last chunk first).
    => Output file location: alongside the original 5GB file generated in Task 1.
    => Properly structured and optimized code for maintainability and efficiency.
*/

//var directoryInformation = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName;

const string ChunksFolderName = "Chunks";
const string MergedFileName = "MergedFile.txt";

var task2Directory = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.Parent.FullName;
var chunksFolderPath = Path.Combine(task2Directory, ChunksFolderName);

if (!Directory.Exists(chunksFolderPath))
{
    Console.WriteLine($"The chunk folder doesn't exist at {chunksFolderPath}.\nPlease run the Task 2 first.");
    return;
}

var solutionDirectory = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.Parent.FullName;    // Location of 5GB File
var outputFilePath = Path.Combine(solutionDirectory, MergedFileName);

var allFolders = Directory.GetDirectories(chunksFolderPath).OrderByDescending(folder => folder).ToList();
using (FileStream outputFileStream = new FileStream(outputFilePath, FileMode.Create, FileAccess.Write))
{
    foreach(var folder in allFolders)
    {
        var chunkFiles = Directory.GetFiles(folder).OrderByDescending(file => file).ToList();
        
        foreach (var chunkFile in chunkFiles)
        {
            using (FileStream chunkFileStream = new FileStream(chunkFile, FileMode.Open, FileAccess.Read))
            {
                chunkFileStream.CopyTo(outputFileStream);
            }
            Console.WriteLine($"{Path.GetFileName(chunkFile)} Merged successfully.");
        }

    }
}

long mergedFileSize = new FileInfo(outputFilePath).Length;
long exceptedFileSize = 5L * 1024 * 1024 * 1024;

if(mergedFileSize == exceptedFileSize)
{
    Console.WriteLine("\nFile Merging Completed");
    Console.WriteLine($"Marged file size is {mergedFileSize / 1024 / 1024 / 1024} GB");
    Console.WriteLine($"Merged file saved at {solutionDirectory}");
}
else
{
    if(mergedFileSize > exceptedFileSize)
    {
        Console.WriteLine("\nFile Merging Completed");
        Console.WriteLine($"Marged file is greater-than {exceptedFileSize / 1024 / 1024 / 1024} GB");
        Console.WriteLine($"Merged file saved at {solutionDirectory}");
    }

    else
    {
        Console.WriteLine("\nFile Merging Completed");
        Console.WriteLine($"Marged file is smaller-than {exceptedFileSize / 1024 / 1024 / 1024} GB");
        Console.WriteLine($"Merged file saved at {solutionDirectory}");
    }

}


