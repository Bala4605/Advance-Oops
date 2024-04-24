using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InterfaceQuestion2
{
    public class StudentInfo : IDisplayInfo

    {   
        private static int s_studentID=1001;
        public string StudentID { get; set; }
         public string Name { get; set; }
         public string FatherName { get; set; }
         public string Phone{ get; set; }
        public StudentInfo(string name,string fatherName,string phone){
            StudentID="SID"+s_studentID++;
            Name=name;
            FatherName=fatherName;
            Phone=phone;}
        public void Display()
        {
            Console.WriteLine($"{"StudentID",-10} {"Name",-10} {"FatherName",-10} {"Phone",-10}");

            Console.WriteLine($"{StudentID,-10} {Name,-10} {FatherName,-10} {Phone,-10}");
        }
    }
}

