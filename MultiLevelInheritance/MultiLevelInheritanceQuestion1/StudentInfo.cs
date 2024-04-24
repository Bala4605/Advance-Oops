using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MultiLevelInheritanceQuestion1;

    public class StudentInfo:PersonalInfo
    {
       
        // RegisterNumber, Standard, Branch, AcadamicYear
        private static int s_studentID=1001;
        public string RegisterNumber { get; }
        public int Standard { get; set; }
        public string Branch { get; set; }
        public int AcadamicYear{ get; set; }
        public StudentInfo(string name,string fatherName,string phone ,string mail,DateTime dob, Gender gender,int standard,string branch,int acadamicYear):base(name, fatherName, phone ,mail, dob, gender){
            RegisterNumber="SID"+s_studentID++;
            Standard=standard;
            Branch=branch;
            AcadamicYear=acadamicYear;
        }
        public StudentInfo(string name,string fatherName,string phone ,string mail,DateTime dob, Gender gender,int standard,string branch,int acadamicYear,string registerNumber):base(name, fatherName, phone ,mail, dob, gender){
            RegisterNumber=registerNumber;
            Standard=standard;
            Branch=branch;
            AcadamicYear=acadamicYear;
        }

        public void ShowInfo(){
            Console.WriteLine($"{"Name",-10} {"FatherName",-10} {"Phone",-10}  {"Mail",-20} {"DOB",-10} {"Gender",-8} {"RegisterNo.",-13}  {"Standard",-10} {"Branch",-10} {"AcadamicYear",-10}");
            Console.WriteLine($"{Name,-10} {FatherName,-10} {Phone,-10}  {Mail,-20} {DOB.ToShortDateString(),-10} {Gender,-8} {RegisterNumber,-13}  {Standard,-10} {Branch,-10} {AcadamicYear,-10}");
            Console.WriteLine();
        }
         public void GetStudentInfo(){
            Console.WriteLine($"{"Name",-10} {"FatherName",-10} {"Phone",-10}  {"Mail",-20} {"DOB",-10} {"Gender",-8} ");
            Console.WriteLine($"{Name,-10} {FatherName,-10} {Phone,-10}  {Mail,-20} {DOB.ToShortDateString(),-10} {Gender,-8} ");
            Console.WriteLine();
        }



    }
