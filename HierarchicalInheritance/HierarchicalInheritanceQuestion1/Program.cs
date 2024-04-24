using System;
namespace HierarchicalInheritanceQuestion1;
class Program{
    public static void Main(string[] args)
    {
        PersonalInfo person1=new PersonalInfo("Bala","Baskar","9150198636","bala@gmail.com",new DateTime(2002,2,17),Gender.Male);
        PersonalInfo person2=new PersonalInfo("santhosh","Thanaraj","9786987636","santhosh@gmail.com",new DateTime(1995,5,19),Gender.Male);
        PersonalInfo person3=new PersonalInfo("John","Paul","9711205899","john@gmail.com",new DateTime(1972,5,1),Gender.Male);
    
        StudentInfo student=new StudentInfo(person1.Name,person1.FatherName,person1.Phone,person1.Mail,person1.DOB,person1.Gender,"B.E","CSE",5);
        TeacherInfo teacher=new TeacherInfo(person2.Name,person2.FatherName,person2.Phone,person2.Mail,person2.DOB,person2.Gender,"CSE","M4","M.sc Maths",4,new DateTime(2022,5,4));
        PrincipalInfo principal=new PrincipalInfo(person3.Name,person3.FatherName,person3.Phone,person3.Mail,person3.DOB,person3.Gender,"M.phil",10,new DateTime(2022,5,4));
        student.ShowInfo();
        teacher.ShowInfo();
        principal.ShowInfo();
    }
}