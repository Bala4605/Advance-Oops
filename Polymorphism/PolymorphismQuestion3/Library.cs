using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PolymorphismQuestion3
{
    public abstract class Library
    {
         private string _serialNumber;
         public string SerialNumber{get {return _serialNumber;}set{_serialNumber=value;}}
         public abstract string  AuthorName{get;set;} 
         public abstract string BookName{get;set;} 
         public abstract string PublisherName{get;set;} 
         public abstract int Year{get;set;}
         public abstract void SetBookInfo(string authorName,string bookName,string publisherName,int year);
         public abstract void DisplayInfo();
         
    }
}