using System;
namespace PolymorphismQuestion4;
class Program{
    public static void Main(string[] args)
    {
        FreeLancer person1=new FreeLancer("Santhosh","Thanraj",Gender.Male,"B.Tech","TestingEngineer",28);
        Syncfusion person2=new Syncfusion("Santhosh","Thanraj",Gender.Male,"B.Tech","TestingEngineer",28,"Chennai");
        person1.CalculateSalary();
        person2.CalculateSalary();
        person1.Display();
        person2.Display();
    }
}