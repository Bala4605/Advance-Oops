using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PolymorphismQuestion4
{
    public class FreeLancer:PersonalDetails
    {   
        public string Role{get;set;}
        public int SalaryAmount{get;set;}
        public int NoOfWorkingDays{get;set;}
        public FreeLancer(string name, string fatherName, Gender gender, string qualification,string role,int noOfWorkingDays) : base(name, fatherName, gender, qualification)
        {
            Role=role;
            NoOfWorkingDays=noOfWorkingDays;
        }
        public virtual void CalculateSalary(){
            SalaryAmount=NoOfWorkingDays*500;
            Console.WriteLine(SalaryAmount);
        }
        public virtual void Display(){
            Console.WriteLine($"{"Name",-15}{"FatherName",-10}{"Gender",-10}{"Qualification",-15}{"Role",-15}{"NoOfWorkingDays",-20}{"SalaryAmount",-15}");
            Console.WriteLine($"{Name,-15}{FatherName,-10}{Gender,-10}{Qualification,-15}{Role,-15}{NoOfWorkingDays,-20}{SalaryAmount,-15}");
        }

       

    }
}