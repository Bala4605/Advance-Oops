using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SealedQuestion1
{
    public sealed class EmployeeInfo
    {
        public string UserID { get; set; }
        public string Password { get; set; }
        public int KeyInfo { get; set; }=100;
         
        public void UpdateInfo(string userID,string password){
            UserID=userID;
            Password=password;
        } 
        public void DisplayInfo(){
            Console.WriteLine($"{UserID} {Password}");
        }
    }
}