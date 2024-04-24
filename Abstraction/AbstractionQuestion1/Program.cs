using System;
namespace AbstractionQuestion1;
class Program{
    public static void Main(string[] args)
    {
        Shape cyclinder=new Cyclinder(5,15);
        Shape cube=new Cubes(5);
        Console.WriteLine($"Cyclinder Area:{cyclinder.CalculateArea()} Cyclinder Volume:{cyclinder.CalculateVolume()}");
        Console.WriteLine($"Cube Area:{cube.CalculateArea()} Cube Volume:{cube.CalculateVolume()}");

    }
}