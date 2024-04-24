using System;
namespace HybridInheritanceQuestion2;
class Program{
    public static void Main(string[] args)
    {
        PersonalInfo person=new PersonalInfo("Bala",Gender.Male,new DateTime(2002,02,17),"9150198636");
        IDInfo id=new IDInfo(person.Name,person.Gender,person.DOB,person.Phone,"VID20201","9865 6534 8745","PJVD9876G");
        SavingAccount saving=new SavingAccount(person.Name,person.Gender,person.DOB,person.Phone,id.VoterID,id.AadharID,id.PANNumber,"87723676322",AccountType.savings,500);
        saving.Deposit(1000);
        saving.Withdraw(200);
        saving.BalanceCheck();
    }
}