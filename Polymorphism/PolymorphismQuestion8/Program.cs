using System;
namespace PolymorphismQuestion8;
class Program{
    public static void Main(string[] args)
    {
        Semester all=new Semester(90,88,98,78,88,76)+new Semester(90,88,98,78,88,76)+new Semester(90,88,98,78,88,76)+new Semester(90,88,98,78,88,76)+new Semester(90,88,98,78,88,76)+new Semester(90,88,98,78,88,76);
        
        Calculator.Calculate(all);
    }
}
