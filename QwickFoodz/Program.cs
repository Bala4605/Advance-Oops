using System;
namespace QwickFoodz;
class Program{
    public static void Main(string[] args)
    {   
        CSVFile.CreateFolder();
        // Operations.AddDefaultdata();
        CSVFile.ReadFromCSV();
        Operations.MainMenu();
        CSVFile.WriteToCSV();
    }
}