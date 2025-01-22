var directoryName = "D:\\Devskill\\C# Professional Programming\\Coding\\csharpb19-IqbalHassanMahmud\\DailyPractice\\src\\CodeExamples\\DirectorySystemExample\\New Directory";

Directory.CreateDirectory(directoryName);

var root = Directory.GetCurrentDirectory();
DirectoryInfo directoryInfo = new DirectoryInfo(root);

root = directoryInfo.Parent.Parent.Parent + "\\New Directory";
Directory.CreateDirectory(root);