using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Grocery
{
    /// <summary>
    /// <see cref="CustomerDetails"/> Class
    /// </summary>
    public class CustomerDetails : PersonalDetails, IBalance
    {   
        /// <summary>
        /// s_customerID
        /// </summary>
        private static int s_customerID=1000;
        /// <summary>
        /// CustomerID
        /// </summary>
        /// <value></value>
        public string CustomerID { get; set; }
        /// <summary>
        /// WalletBalance
        /// </summary>
        /// <value></value>
        public int WalletBalance { get;set;}
        /// <summary>
        /// Constructor of <see cref="CustomerDetails"/>
        /// </summary>
        /// <param name="name"></param>
        /// <param name="fatherName"></param>
        /// <param name="gender"></param>
        /// <param name="mobile"></param>
        /// <param name="dob"></param>
        /// <param name="mailID"></param>
        /// <param name="balance"></param>
        /// <returns></returns>
        public CustomerDetails(string name, string fatherName, Gender gender, string mobile, DateTime dob, string mailID,int balance) : base(name, fatherName, gender, mobile, dob, mailID)
        {
            CustomerID="CID"+ ++s_customerID;
            WalletBalance=balance;
            
        }
        public CustomerDetails(string customerID, string name, string fatherName, Gender gender, string mobile, DateTime dob, string mailID,int balance) : base(name, fatherName, gender, mobile, dob, mailID)
        {
            CustomerID=customerID;
            WalletBalance=balance;
            s_customerID=int.Parse(customerID.Remove(0,3));
            
        }

       
        /// <summary>
        /// WalletRecharge method
        /// </summary>
        /// <param name="amount"></param>
        public void WalletRecharge(int amount)
        {
            WalletBalance+=amount;
        }
        /// <summary>
        /// Wallet Deduct Method
        /// </summary>
        /// <param name="amount"></param> <summary>
        /// 
        /// </summary>
        /// <param name="amount"></param>
        public void Deduct(int amount)
        {
            WalletBalance-=amount;
        }
    }
}