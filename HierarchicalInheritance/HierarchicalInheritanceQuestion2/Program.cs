using System;
namespace HierarchicalInheritanceQuestion2;
class Program{
    public static void Main(string[] args)
    {
        SalaryInfo salary1=new SalaryInfo(12000,5);
        SalaryInfo salary2=new SalaryInfo(15000,5);

        PermanentEmployee employee1=new PermanentEmployee(salary2.BasicSalary,salary2.Month,EmployeeType.Permanent);
        TemporaryEmployee employee2=new TemporaryEmployee(salary1.BasicSalary,salary1.Month,EmployeeType.Permanent);
        employee1.CalculateSalary();
        employee2.CalculateSalary();
        employee1.ShowSalary();
        employee2.ShowSalary();
    }
}