using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MultipleInheritanceQuestion1
{
    public class RegisterPerson : PersonalInfo,IShowData,IFamilyInfo
    {
       private static int s_registerId=1001;
        public string RegistrationNumber { get; set; }
        public DateTime DateOfRegistration{ get; set; }
        public string FatherName { get;set;}
        public string MotherName { get;set;}
        public string HouseAddress { get;set;}
        public int NoOfSiblings { get;set;}
         public RegisterPerson(string name, string phone, DateTime dob, Gender gender, MaritalStatus maritalStatus,string fatherName,string motherName,string houseAddress,int noOfSiblings) : base(name, phone, dob, gender, maritalStatus)
        {
            RegistrationNumber="RID"+s_registerId++;
            DateOfRegistration=DateTime.Now;
            FatherName=fatherName;
            MotherName=motherName;
            HouseAddress=houseAddress;
            NoOfSiblings=noOfSiblings;
            
        }
        public override void ShowInfo(){
            Console.WriteLine();
            Console.WriteLine($"{RegistrationNumber,-10} {Name,-10} {Gender,-10} {DOB.ToShortDateString(),-10} {Phone,-10} {MaritalStatus,-10} {FatherName,-10} {MotherName,-10} {HouseAddress,-10} {NoOfSiblings,-10} {DateOfRegistration.ToShortDateString(),-10}");
        }
    }
}