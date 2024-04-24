using System;
namespace MultipleInheritanceQuestion2;
class Program{
    public static void Main(string[] args)
    {
        ShiftDezire shift=new ShiftDezire("Suzuki","MD201SF",FuelType.Petrol,6,"Red",30,400,12345,65432);
        Eco eco=new Eco("TATA","MD201SF",FuelType.Diesel,6,"Black",25,350,12654,65765);
        shift.ShowDetails();
        Console.WriteLine();
        eco.ShowDetails();
        
    }
}