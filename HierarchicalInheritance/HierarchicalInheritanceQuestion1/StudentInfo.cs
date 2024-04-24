using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HierarchicalInheritanceQuestion1
{
    public class StudentInfo:PersonalInfo
    {
       
        // RegisterNumber, Standard, Branch, AcadamicYear
        private static int s_studentID=1001;
        public string StudentID { get; }
        public string Degree { get; set; }
        public string Department { get; set; }
        public int Semester{ get; set; }
        public StudentInfo(string name,string fatherName,string phone ,string mail,DateTime dob, Gender gender,string degree,string department,int semsester):base(name, fatherName, phone ,mail, dob, gender){
            StudentID="SID"+s_studentID++;
            Degree=degree;
            Department=department;
            Semester=semsester;
        }
        public void ShowInfo(){
            Console.WriteLine($"{"Name",-10} {"FatherName",-10} {"Phone",-10}  {"Mail",-20} {"DOB",-10} {"Gender",-8} {"RegisterNo.",-13}  {"Standard",-10} {"Branch",-10} {"AcadamicYear",-10}");
            Console.WriteLine($"{Name,-10} {FatherName,-10} {Phone,-10}  {Mail,-20} {DOB.ToShortDateString(),-10} {Gender,-8} {StudentID,-13}  {Degree,-10} {Department,-10} {Semester,-10}");
            Console.WriteLine();
        }



    }
}