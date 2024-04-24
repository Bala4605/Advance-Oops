using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HierarchicalInheritanceQuestion2
{
    public class TemporaryEmployee:SalaryInfo
    {
        private static int s_temployeeId=1001;
         EmployeeType EmployeeType{get;set;}
        public string EmployyeID{get;set;}
        public double DA=0.15;
        public double HRA=0.13;
        
        public double Salary{get;set;}
        public TemporaryEmployee(int basicSalary, int month,EmployeeType employeeType) : base(basicSalary, month)
        {   
            EmployyeID="TID"+s_temployeeId++;
            EmployeeType=employeeType;

        }
        public void CalculateSalary(){
            Salary=(DA*base.BasicSalary)+(HRA*base.BasicSalary)+BasicSalary;

        }
        public void ShowSalary(){
           Console.WriteLine($"Salary :{Salary}" );
            
        }
        
    }
}