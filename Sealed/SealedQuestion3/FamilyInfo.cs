using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SealedQuestion3
{
    public class FamilyInfo:PersonalInfo
    {
        public new string FatherName{get;set;} 
        public string MotherName{get;set;} 
        public int NoOfSiblings{get;set;} 
        public string NativePlace{get;set;}
        
        public sealed override void Update(string name, string fatherName, string phone, string mail, Gender gender)
        {
            base.Update(name, fatherName, phone, mail, gender);
            
        }
        public sealed override  void  Display(){
            Console.WriteLine($"{Name}{FatherName}{Phone}{Mail}{Gender}");
         }
    }
}