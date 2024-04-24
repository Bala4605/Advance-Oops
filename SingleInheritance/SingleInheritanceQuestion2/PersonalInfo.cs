using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SingleInheritanceQuestion2
{   public enum Gender{Male,Female}
    public class  PersonalInfo
    {
         //Name, FatherName, Phone ,Mail, DOB, Gender
         public string Name { get; set; }
         public string FatherName { get; set; }
         public string Phone{ get; set; }
         public string Mail { get; set; }
         public DateTime DOB{get;set;}
         public Gender Gender{get;set;}
         public PersonalInfo(string name,string fatherName,string phone ,string mail,DateTime dob, Gender gender){
            Name=name;
            FatherName=fatherName;
            Phone=phone;
            Mail=mail;
            DOB=dob;
            Gender=gender;
         }
    }
}