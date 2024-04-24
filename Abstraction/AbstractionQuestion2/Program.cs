using System;
namespace AbstractionQuestion2;
class Program{
    public static void Main(string[] args)
    {
        EEEdepartment eee=new EEEdepartment();
        eee.SetBookInfo("author1","EEE Basics","Arihant",2021);
        eee.DisplayInfo();
        CSEDepartment cse=new CSEDepartment();
        cse.SetBookInfo("author2","CSE Basics","Arihant",2023);
        cse.DisplayInfo();
    }
}