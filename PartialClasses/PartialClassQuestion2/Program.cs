using System;
namespace PartialClassQuestion2;
class Program{
    public static void Main(string[] args)
    {
    StudentInfo student=new StudentInfo("Bala",Gender.Male,new DateTime(2002,2,17),"9150198636",78,79,77);
    student.TotalAndPercentage();
    student.Display();
    }
}