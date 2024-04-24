using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PartialClassQuestion2
{
    public enum Gender{Male,Female}
    public partial class StudentInfo
    {
         private static int s_studentID=1001;
         public string StudentID{get;set;} 
         public string Name{get;set;} 
         public  Gender Gender{get;set;} 
         public DateTime DOB{get;set;} 
         public string  Mobile{get;set;} 

         public int Maths{get;set;} 
         public int Physics{get;set;} 
         public int Chemistry{get;set;} 
        
    }
}