using System;
using System.Runtime.InteropServices;
namespace SingleInheritanceQuestion1;
class Program{
    public static void Main(string[] args)
    {
        PersonalInfo person1=new PersonalInfo("Bala","Baskar","9150198636","bala@gmail.com",new DateTime(2002,2,17),Gender.Male);
        PersonalInfo person2=new PersonalInfo("santhosh","Thanaraj","9786987636","santhosh@gmail.com",new DateTime(2000,5,19),Gender.Male);
    
        StudentInfo student1=new StudentInfo(person1.Name,person1.FatherName,person1.Phone,person1.Mail,person1.DOB,person1.Gender,11,"CS",2017);
        StudentInfo student2=new StudentInfo(person2.Name,person2.FatherName,person2.Phone,person2.Mail,person2.DOB,person2.Gender,12,"CS",2018);
    
        student1.ShowInfo();
        student2.ShowInfo();
    }   
}