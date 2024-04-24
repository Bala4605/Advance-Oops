using System;
namespace CalculatorApp;

class Program{
    public static void Main(string[] args)
    {   CircleArea area=new CircleArea(5);
        Console.WriteLine(area.CalculateCircleArea());
        CyclinderArea volume=new CyclinderArea(10,20);
        volume.CalculateVolume();
    }
}