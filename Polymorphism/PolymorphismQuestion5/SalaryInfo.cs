using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PolymorphismQuestion5
{
    public class SalaryInfo : EmployeeInfo
    {  
        public int NoOfWorkingDays{get;set;}
        public SalaryInfo(string name, string fatherName, string mobileNumber, Gender gender,int noOfWorkingDays) : base(name, fatherName, mobileNumber, gender)
        {
            NoOfWorkingDays=noOfWorkingDays;
        }
        public override void Display()
        {
            Console.WriteLine($"{"EmployeeID",-15}{"Name",-15}{"FatherName",-15}{"MobileNumber",-15}{"Gender",-15}{"NoOfWorkingDays",-15}{"salary",-15}");
            Console.WriteLine($"{EmployeeID,-15}{Name,-15}{FatherName,-15}{MobileNumber,-15}{Gender,-15}{NoOfWorkingDays,-15}{ NoOfWorkingDays*500,-15}");
        }
    }
}