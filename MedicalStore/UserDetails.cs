using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MedicalStore
{
    /// <summary>
    /// <see cref="UserDetails"/> Class
    /// </summary>
    public class UserDetails : PersonalDetails, IWallet
    {
        /// <summary>
        /// static s_userID
        /// </summary>
        private static int s_userID=1000;
        /// <summary>
        /// _balance
        /// </summary>
        private int _balance;
        /// <summary>
        /// UserID
        /// </summary>
        /// <value></value>
        public string UserID { get; }
        /// <summary>
        /// WalletBalance
        /// </summary>
        /// <value></value>
        public int WalletBalance {get{return _balance;}}
        /// <summary>
        /// Constructor of  <see cref="UserDetails"/> Class
        /// </summary>
        /// <param name="name"></param>
        /// <param name="age"></param>
        /// <param name="city"></param>
        /// <param name="phone"></param>
        /// <param name="walletBalance"></param> <summary>
        /// 
        /// </summary>
        /// <param name="name"></param>
        /// <param name="age"></param>
        /// <param name="city"></param>
        /// <param name="phone"></param>
        /// <param name="walletBalance"></param>
        /// <returns></returns>
        public UserDetails(string name, int age, string city, string phone,int walletBalance) : base(name, age, city, phone)
        {
            UserID="UID"+ ++s_userID;
            _balance=walletBalance;

        }
        /// <summary>
        /// Constructor of  <see cref="UserDetails"/> Class
        /// </summary>
         public UserDetails(string userID,string name, int age, string city, string phone,int walletBalance) : base(name, age, city, phone)
        {
            UserID=userID;
            _balance=walletBalance;
            s_userID=int.Parse(userID.Remove(0,3));

        }

        
        /// <summary>
        /// DeductBalance method
        /// </summary>
        /// <param name="amount"></param>
        public void DeductBalance(int amount)
        {
            _balance-=amount;
        }

        /// <summary>
        /// WalletRecharge method
        /// </summary>
        /// <param name="amount"></param>
        public void WalletRecharge(int amount)
        {
            _balance+=amount;
        }
    }
}