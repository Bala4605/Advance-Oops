using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PolymorphismQuestion4
{
    public class Syncfusion :FreeLancer
    {   
        private static int s_employeeID=1001;
        public string WorkLocation { get; set; }
        public string EmployeeID { get; set; }

        public Syncfusion(string name, string fatherName, Gender gender, string qualification, string role, int noOfWorkingDays,string workLocation) : base(name, fatherName, gender, qualification, role, noOfWorkingDays)
        {
            EmployeeID="EID"+s_employeeID++;
            WorkLocation=workLocation;
        }
        public override void CalculateSalary(){
            SalaryAmount=NoOfWorkingDays*500;
            Console.WriteLine(SalaryAmount);
        }
        public override void Display(){
            Console.WriteLine($"{"EmployeeID",-15}{"Name",-15}{"FatherName",-10}{"Gender",-10}{"Qualification",-15}{"Role",-15}{"NoOfWorkingDays",-20}{"SalaryAmount",-15}{"WorkLocation",-15}");
            Console.WriteLine($"{EmployeeID,-15}{Name,-15}{FatherName,-10}{Gender,-10}{Qualification,-15}{Role,-15}{NoOfWorkingDays,-20}{SalaryAmount,-15}{WorkLocation,-15}");
        }
        
       
    }
}