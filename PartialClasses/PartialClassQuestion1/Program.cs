using System;
namespace PartialClassQuestion1;
class Program{
    public static void Main(string[] args)
    {
        EmployeeInfo employee=new EmployeeInfo("Bala",Gender.Male,new DateTime(2002,2,17),"9150198636");
        employee.Update("Bala Baskar",Gender.Male,new DateTime(2002,2,17),"9150198636");
        employee.Display();

    }
}