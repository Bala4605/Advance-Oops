using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PolymorphismQuestion8
{
    public class Semester
    {
        public int Subject1 { get; set; }
        public int Subject2 { get; set; }
        public int Subject3 { get; set; }
        public int Subject4 { get; set; }
        public int Subject5 { get; set; }
        public int Subject6 { get; set; }
        public Semester(int subject1,int subject2,int subject3,int subject4,int subject5,int subject6)
        {
            Subject1=subject1;
            Subject2=subject2;
            Subject3=subject3;
            Subject4=subject4;
            Subject5=subject5;
            Subject6=subject6;
        }
        public static Semester operator+(Semester value1,Semester value2){
            Semester semester=new Semester(0,0,0,0,0,0);
            semester.Subject1=value1.Subject1+value2.Subject1;
            semester.Subject2=value1.Subject2+value2.Subject2;
            semester.Subject3=value1.Subject3+value2.Subject3;
            semester.Subject4=value1.Subject4+value2.Subject4;
            semester.Subject5=value1.Subject5+value2.Subject5;
            semester.Subject6=value1.Subject6+value2.Subject6;
            return semester;
        }
    }
}