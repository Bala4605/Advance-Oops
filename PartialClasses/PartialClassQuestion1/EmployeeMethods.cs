using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PartialClassQuestion1
{
    public partial class EmployeeInfo
    {
        public void Update(string name,Gender gender,DateTime dob,string mobile){
            Name=name;
            Gender=gender;
            DOB=dob;
            Mobile=mobile;
        }
        public void Display(){
            Console.WriteLine($"{"EmployeeID",-15} {"Name",-15} {"Gender",-15} {"DOB",-15} {"Mobile",-15}");

            Console.WriteLine($"{EmployeeID,-15} {Name,-15} {Gender,-15} {DOB.ToShortDateString(),-15} {Mobile,-15}");
        }
    }
}