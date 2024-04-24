using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PolymorphismQuestion5
{
    public class EmployeeInfo : PersonalInfo
    {
        private static int  s_employeeID=1001; 
        public string EmployeeID { get; set; }
        public EmployeeInfo(string name, string fatherName, string mobileNumber, Gender gender) : base(name, fatherName, mobileNumber, gender)
        {
            EmployeeID="EID"+s_employeeID++;
        }

        public override void Display()
        {
            Console.WriteLine($"{"EmployeeID",-15}{"Name",-15}{"FatherName",-15}{"MobileNumber",-15}{"Gender",-15}");
            Console.WriteLine($"{EmployeeID,-15}{Name,-15}{FatherName,-15}{MobileNumber,-15}{Gender,-15}");
        }
    }
}