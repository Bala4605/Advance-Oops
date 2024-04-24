using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MultipleInheritanceQuestion1;

namespace MultipleInheritanceQuestion1
{   public enum Gender{Male,Female}
public enum MaritalStatus{Married,single}
    public class  PersonalInfo:IShowData
    {
         //Name, FatherName, Phone ,Mail, DOB, Gender
         public string Name { get; set; }
        
         public string Phone{ get; set; }
         public MaritalStatus MaritalStatus { get; set; }
         public DateTime DOB{get;set;}
         public Gender Gender{get;set;}
         public PersonalInfo(string name,string phone,DateTime dob, Gender gender,MaritalStatus maritalStatus){
            Name=name;
            MaritalStatus=maritalStatus;
            Phone=phone;
            DOB=dob;
            Gender=gender;
         }

        public virtual void ShowInfo()
        {
            Console.WriteLine($"{"Name",-15} {"Gender",-15} {"DOB",-15} {"Phone",-15} {"MaritalStatus",-15}");

            Console.WriteLine($"{Name,-15} {Gender,-15} {DOB.ToShortDateString(),-15} {Phone,-15} {MaritalStatus,-15}");
        }
    }
}