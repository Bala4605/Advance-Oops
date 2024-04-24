using System;
using MultipleInheritanceQuestion1;
namespace MultipleInheritanceQuetion1;
class Program{
    public static void Main(string[] args)
    {
        PersonalInfo person1=new PersonalInfo("Bala","9150198636",new DateTime(2002,2,17),Gender.Male,MaritalStatus.single);
        person1.ShowInfo();
        RegisterPerson register=new RegisterPerson(person1.Name,person1.Phone,person1.DOB,person1.Gender,person1.MaritalStatus,"Baskar","Sumathi","Chennai",3);
        register.ShowInfo();
    }
}