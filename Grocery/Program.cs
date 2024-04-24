using System;
namespace Grocery;
class Program{
    public static void Main(string[] args)
    {
        CSVFile.CreateFolder();
        // Operation.AddDefault();
        CSVFile.ReadFromCSV();
        Operation.MainMenu();
        CSVFile.WriteToCSV();
    }
}
