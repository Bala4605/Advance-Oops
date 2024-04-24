using System;
using System.Collections.Generic;
using System.Linq;


namespace SingleInheritanceQuestion2
{
    public class AccountInfo:PersonalInfo
    {
       
        // RegisterNumber, Standard, Branch, AcadamicYear
        private static int s_accountID=1001;
        public string AccountNumber{ get; }
        public string IFSCCode{ get; set; }
        public string Branch { get; set; }
        public int Balance{ get; set; }
        public AccountInfo(string name,string fatherName,string phone ,string mail,DateTime dob, Gender gender,string ifscCode,string branch,int balance):base(name, fatherName, phone ,mail, dob, gender){
            AccountNumber="AID"+s_accountID++;
            IFSCCode=ifscCode;
            Branch=branch;
            Balance=balance;
        }
        public void ShowInfo(){
            Console.WriteLine($"{"Name",-10} {"FatherName",-10} {"Phone",-10}  {"Mail",-20} {"DOB",-10} {"Gender",-8} {"AccountNo.",-13}  {"IFSCcode",-10} {"Branch",-10} {"Balance",-10}");
            Console.WriteLine($"{Name,-10} {FatherName,-10} {Phone,-10}  {Mail,-20} {DOB.ToShortDateString(),-10} {Gender,-8} {AccountNumber,-13}  {IFSCCode,-10} {Branch,-10} {Balance,-10}");
            Console.WriteLine();
        }

        public void Deposit(int amount){
            Balance+=amount;
             Console.WriteLine($"Deposit :{amount}");

        }
         public void Withdraw(int amount){
            Balance-=amount;
             Console.WriteLine($"withdraw :{amount}");

        }
         public void ShowBalance(){
            Console.WriteLine($"Balance :{Balance}");

        }



    }
}
    
