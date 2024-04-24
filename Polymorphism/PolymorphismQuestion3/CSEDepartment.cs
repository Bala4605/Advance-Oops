using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PolymorphismQuestion3
{
    public class CSEDepartment : Library
    {   private static int s_count=1001;
        public override string AuthorName { get;set; }
        public override string BookName { get;set; }
        public override string PublisherName { get;set; }
        public override int Year { get;set; }

        public override void DisplayInfo()
        {
            Console.WriteLine($"{"AuthorName",-15}{"BookName",-15}{"PublisherName",-15}{"Year",-15}");

            Console.WriteLine($"{AuthorName,-15}{BookName,-15}{PublisherName,-15}{Year,-15}");
        }

        public override void SetBookInfo(string authorName,string bookName,string publisherName,int year)
        {   
            base.SerialNumber="LIB"+s_count++;
            AuthorName=authorName;
            BookName=bookName;
            PublisherName=publisherName;
            Year=year;
        }
    }
}