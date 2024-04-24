using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HierarchicalInheritanceQuestion1
{
    public class PrincipalInfo : PersonalInfo
    {
           private static int s_principalID=1001;
    public string PrincipalID {get;set;}
  
    public string Qualification {get;set;}
    public int YearOfExperience {get;set;}
    public DateTime DateOfJoining {get;set;}
   
        public PrincipalInfo(string name, string fatherName, string phone, string mail, DateTime dob, Gender gender,string qualification,int yearOfExperience,DateTime dateOfJoining) : base(name, fatherName, phone, mail, dob, gender)
        {
        PrincipalID="PID"+s_principalID++;   
        Qualification=qualification;
        YearOfExperience=yearOfExperience;
        DateOfJoining=dateOfJoining;
        }
         public void ShowInfo(){
         Console.WriteLine($"{"Name",-10} {"FatherName",-10} {"Phone",-10}  {"Mail",-15} {"DOB",-10} {"Gender",-10} {"PrincipalID",-10} {"YearOfExperience",-15} {"DateOfJoining",-10}");
         Console.WriteLine($"{Name,-10} {FatherName,-10} {Phone,-10}  {Mail,-15} {DOB.ToShortDateString(),-10} {Gender,-10} {PrincipalID,-10} {YearOfExperience,-15} {DateOfJoining.ToShortDateString(),-10}");
    }
    }
}