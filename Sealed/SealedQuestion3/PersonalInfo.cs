using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SealedQuestion3
{   public enum Gender{Male,Female}
    public class  PersonalInfo
    {
         //Name, FatherName, Phone ,Mail, DOB, Gender
         public string Name { get; set; }
         public string FatherName { get; set; }
         public string Phone{ get; set; }
         public string Mail { get; set; }
         
         public Gender Gender{get;set;}
         public virtual void Update(string name,string fatherName,string phone ,string mail, Gender gender){
            Name=name;
            FatherName=fatherName;
            Phone=phone;
            Mail=mail;
            Gender=gender;
         }
         public virtual void Display(){
            Console.WriteLine($"{Name}{FatherName}{Phone}{Mail}{Gender}");
         }
         
    }
}