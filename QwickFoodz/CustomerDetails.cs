using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QwickFoodz
{
    public class CustomerDetails : PersonalDetails, IBalance
    {
        private int  _balance;
        private static int s_customerID=1000;
        public string CustomerID{get;}
        public int WalletBalance {get{return  _balance;}}
        public CustomerDetails(string name, string fatherName, Gender gender, string mobile, DateTime dob, string mailID,string location) : base(name, fatherName, gender, mobile, dob, mailID,location)
        {
            CustomerID="CID"+ ++s_customerID;
        }
        public CustomerDetails(string name, string fatherName, Gender gender, string mobile, DateTime dob, string mailID,string location,int balance) : base(name, fatherName, gender, mobile, dob, mailID,location)
        {
            CustomerID="CID"+ ++s_customerID;
            _balance=balance;
        }
        public CustomerDetails(string customerID,string name, string fatherName, Gender gender, string mobile, DateTime dob, string mailID,string location,int balance) : base(name, fatherName, gender, mobile, dob, mailID,location)
        {
             CustomerID=customerID;
            _balance=balance;
            s_customerID=int.Parse(CustomerID.Remove(0,3));
        }
        

        public void DeductBalance(int amount)
        {
            _balance-=amount;
        }

        public void WalletRecharge(int amount)
        {
            _balance+=amount;
        }
    }
}