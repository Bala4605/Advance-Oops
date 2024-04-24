using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HierarchicalInheritanceQuestion2
{public enum EmployeeType{Permanent,Temporary}
    public class PermanentEmployee : SalaryInfo
    {  private static int s_pemployeeId=1001;
         EmployeeType EmployeeType{get;set;}
        public string EmployyeID{get;set;}
        public double DA=0.2;
        public double HRA=0.18;
        public double PF=0.1;
        public double Salary{get;set;}
        public PermanentEmployee(int basicSalary, int month,EmployeeType employeeType) : base(basicSalary, month)
        {   
            EmployyeID="PID"+s_pemployeeId++;
            EmployeeType=employeeType;

        }
        public void CalculateSalary(){
            Salary=(DA*base.BasicSalary)+(HRA*base.BasicSalary)-(PF*base.BasicSalary)+BasicSalary;

        }
        public void ShowSalary(){
           Console.WriteLine($"Salary :{Salary}" );
            
        }
    }
}