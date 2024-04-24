using System;
using System.Runtime.InteropServices;
namespace SingleInheritanceQuestion2;
class Program{
    public static void Main(string[] args)
    {
        PersonalInfo person1=new PersonalInfo("Bala","Baskar","9150198636","bala@gmail.com",new DateTime(2002,2,17),Gender.Male);
        PersonalInfo person2=new PersonalInfo("santhosh","Thanaraj","9786987636","santhosh@gmail.com",new DateTime(2000,5,19),Gender.Male);
    
        AccountInfo account1=new AccountInfo(person1.Name,person1.FatherName,person1.Phone,person1.Mail,person1.DOB,person1.Gender,"IFSC001001","Chennai",0);
        AccountInfo account2=new AccountInfo(person2.Name,person2.FatherName,person2.Phone,person2.Mail,person2.DOB,person2.Gender,"IFSC001002","Chennai",0);
        account1.Deposit(2000);
        account1.Withdraw(500);
        account1.ShowBalance();
        account1.ShowInfo();
        Console.WriteLine();

        account2.Deposit(3000);
        account2.Withdraw(750);
        account2.ShowBalance();
        account2.ShowInfo();
    }   
}