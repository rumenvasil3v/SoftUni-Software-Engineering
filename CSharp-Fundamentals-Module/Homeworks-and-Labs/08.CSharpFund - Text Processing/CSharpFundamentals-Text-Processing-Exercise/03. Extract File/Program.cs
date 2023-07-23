namespace _03._Extract_File
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // C:\Internal\training-internal\Template.pptx
            // C:\Projects\Data-Structures\LinkedList.cs 
            // D:\SoftUni-Software-Engineering\CSharp-Fundamentals-Module\Homeworks-and-Labs\CSharpFund - Common-Lections\Software-Development-Concepts 2.cs
            string pathOfFile = Console.ReadLine();

            int extensionIndex = pathOfFile.LastIndexOf('.');
            int fileNameIndex = pathOfFile.LastIndexOf('\\');

            string fileName = pathOfFile.Substring(fileNameIndex + 1, extensionIndex - fileNameIndex - 1);
            string fileExtension = pathOfFile.Substring(extensionIndex + 1);

            Console.WriteLine($"File name: {fileName}");
            Console.WriteLine($"File extension: {fileExtension}");
        }
    }
}