using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InterfaceQuestion2
{
    public class EmployeeInfo : IDisplayInfo
    {
        private static int s_employeeID=1001;
        public string EmployeeID { get; set; }
        public string Name { get; set; }
        public string FatherName { get; set; }
        public EmployeeInfo(string name,string fatherName){
            EmployeeID="SF"+s_employeeID++;
            Name=name;
            FatherName=fatherName;}
        public void Display()
        {   
            Console.WriteLine($"{"EmployeeID",-10} {"Name",-10} {"FatherName",-10}");

            Console.WriteLine($"{EmployeeID,-10} {Name,-10} {FatherName,-10}");
        }
    }
}