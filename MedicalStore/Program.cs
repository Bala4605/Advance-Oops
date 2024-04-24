using System;
namespace MedicalStore;
class Program{
    public static void Main(string[] args)
    {   
        CSVFile.CreateFolder();
        // Operations.AddDefault();
        CSVFile.ReadFromCSV();
        Operations.MainMenu();
        CSVFile.WriteToCSV();
    }
}