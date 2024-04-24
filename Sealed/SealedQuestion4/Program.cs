using System;
namespace SealedQuestion4;
class Program{
public static void Main(string[] args)
{
    CylinderCalculator cyclinder=new CylinderCalculator();
    Console.WriteLine($"Cyclinder Area :{cyclinder.Area(5)}");
    Console.WriteLine($"Cyclinder volume :{cyclinder.Volume(5,8)}");
}
}