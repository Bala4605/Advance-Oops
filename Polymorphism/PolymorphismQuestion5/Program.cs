using System;
namespace PolymorphismQuestion5;
class Program{
    public static void Main(string[] args)
    {
        PersonalInfo employee=new EmployeeInfo("Bala","Baskar","9150198636",Gender.Male);
        employee.Display();
        SalaryInfo salary=new SalaryInfo(employee.Name,employee.FatherName,employee.MobileNumber,employee.Gender,21);
        salary.Display();
    }
}