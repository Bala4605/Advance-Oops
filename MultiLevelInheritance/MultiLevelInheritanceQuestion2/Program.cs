using System;
namespace MultiLevelInheritanceQuestion2;
class Program{
    public static void Main(string[] args)
    {
        DepartmentDetails department1=new DepartmentDetails("B.E","CSE");
        DepartmentDetails department2=new DepartmentDetails("B.E","EEE");

        RackInfo rack1=new RackInfo(department1.Degree,department1.DepartmentName,2,20);
        RackInfo rack2=new RackInfo(department2.Degree,department2.DepartmentName,5,12);

        BookInfo book1=new BookInfo(department1.Degree,department1.DepartmentName,rack1.RackNumber,rack1.ColumnNumber,"C#","Author1",250);
        BookInfo book2=new BookInfo(department2.Degree,department2.DepartmentName,rack2.RackNumber,rack2.ColumnNumber,"javascript","Author2",350);
    
        book1.DisplayInfo();
        book2.DisplayInfo();
    }
}