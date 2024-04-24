using System;
namespace InterfaceQuestion2;
class Program{
    public static void Main(string[] args)
    {
        IDisplayInfo student=new StudentInfo("Bala","Baskar","9150198636");
        IDisplayInfo employee=new EmployeeInfo("Shantosh","Thanaraj");
        student.Display();
        Console.WriteLine();
        employee.Display();


    }
}