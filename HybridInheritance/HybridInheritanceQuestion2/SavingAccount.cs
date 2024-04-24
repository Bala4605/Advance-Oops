using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HybridInheritanceQuestion2
{   
    public enum AccountType{savings,Current}
    public class SavingAccount : IDInfo, ICalculate, IBankInfo
    {
        

        public string BankName { get;set; }
        public string IFSC{ get;set; }
        public string Branch { get;set; }

        public string AccountNumber{get;set;}
        public AccountType AccountType{get;set;}
        public int Balance{get;set;}
        public SavingAccount(string name, Gender gender, DateTime dob, string phone, string voterID, string aadharID, string panNumber,string accountNumber,AccountType accountType,int balance) : base(name, gender, dob, phone, voterID, aadharID, panNumber)
        {
            AccountNumber=accountNumber;
            AccountType=accountType;
            Balance=balance;
        }
        public void BalanceCheck()
        {
           Console.WriteLine(Balance);
        }

        public void Deposit(int amount)
        {
            Balance+=amount;
           
        }

        public void Withdraw(int amount)
        {
         Balance-=amount;
        }
    }
}