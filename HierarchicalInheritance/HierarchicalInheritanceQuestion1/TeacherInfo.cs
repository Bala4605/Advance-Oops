using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HierarchicalInheritanceQuestion1
{
    public class TeacherInfo : PersonalInfo
    {
    private static int s_teacherID=1001;
    public string TeacherID {get;set;}
    public string Department {get;set;}
    public string SubjectTeaching {get;set;}
    public string Qualification {get;set;}
    public int YearOfExperience {get;set;}
    public DateTime DateOfJoining {get;set;}
    public TeacherInfo(string name, string fatherName, string phone, string mail, DateTime dob, Gender gender,string department,string subjectTeaching,string qualification,int yearOfExperience,DateTime dateOfJoining) : base(name, fatherName, phone, mail, dob, gender)
    {
        TeacherID="TID"+s_teacherID++;
        Department=department;
        SubjectTeaching=subjectTeaching;
        Qualification=qualification;
        YearOfExperience=yearOfExperience;
        DateOfJoining=dateOfJoining;
    }
    public void ShowInfo(){
         Console.WriteLine($"{"Name",-8} {"FatherName",-8} {"Phone",-8}  {"Mail",-8} {"DOB",-8} {"Gender",-8} {"TeacherID",-8} {"Department",-8} {"SubjectTeaching",-8} {"YearOfExperience",-8} {"DateOfJoining",-8}");
         Console.WriteLine($"{Name,-8} {FatherName,-8} {Phone,-8}  {Mail,-8} {DOB.ToShortDateString(),-8} {Gender,-8} {TeacherID,-8} {Department,-8} {SubjectTeaching,-8} {YearOfExperience,-8} {DateOfJoining.ToShortDateString(),-8}");
    }
    }

}