using System;
namespace AbstractionQuestion3;
class Program{
    public static void Main(string[] args)
    {
        Car maruthi=new MarurthiSwift(EngineType.Petrol,CarType.Hatchback,8,800000);
        Car suzuki=new SuzukiCiaz(EngineType.Diesel,CarType.Suv,6,500000);
        maruthi.DisplayCarDetail();
        Console.WriteLine($"EngineType :{maruthi.GetEngineType()}");
        Console.WriteLine($"Car Type :{maruthi.GetCarType()}");
        Console.WriteLine($"No Of seats :{maruthi.GetNoOfSeats()}");
        Console.WriteLine($"No Of Wheels :{maruthi.GetPrice()}");
        Console.WriteLine();
        suzuki.DisplayCarDetail();
        Console.WriteLine($"EngineType :{suzuki.GetEngineType()}");
        Console.WriteLine($"Car Type :{suzuki.GetCarType()}");
        Console.WriteLine($"No Of seats :{suzuki.GetNoOfSeats()}");
        Console.WriteLine($"No Of Wheels :{suzuki.GetPrice()}");
    }
}