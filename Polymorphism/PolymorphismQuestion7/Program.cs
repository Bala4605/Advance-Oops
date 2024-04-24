using System;
namespace PolymorphismQuestion7;
class Program{
    public static void Main(string[] args)
    {
        AttendanceDetails attendance=new AttendanceDetails(20,20,30)+new AttendanceDetails(10,20,30)+new AttendanceDetails(10,20,30);
        Console.WriteLine($"Salary :{attendance.TotalWorkingDays*500}");
    }
}