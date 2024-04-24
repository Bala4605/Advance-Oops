using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MultiLevelInheritanceQuestion2
{
    public class BookInfo : RackInfo
    {  
        private static int s_bookID=1001;
        public string BookID { get; set; }

        public string BookName { get; set; }
        public string AuthorName { get; set; }
        public int Price { get; set; }
        public BookInfo(string departmentName, string degree, int rackNumber, int columnNumber,string bookName,string authorName,int price) : base(departmentName, degree, rackNumber, columnNumber)
        {
            BookID="BID"+s_bookID++;
            BookName=bookName;
            AuthorName=authorName;
            Price=price;
        }
        public void DisplayInfo(){
            Console.WriteLine($"{"Degree",-15} {"DepartmentName",-15} {"RackNumber",-15} {"ColumnNumber",-15} {"BookID",-15} {"BookName",-15} {"AuthorName",-15} {"Price",-15} ");
            Console.WriteLine($"{base.Degree,-15} {base.DepartmentName,-15} {base.RackNumber,-15} {base.ColumnNumber,-15} {BookID,-15} {BookName,-15} {AuthorName,-15} {Price,-15} ");
        }
    }
}