using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HybridInheritanceQuestion1
{
    public class Marksheet : TheoryExamMarks, ICalculate
    {
        public int ProjectMark { get;set; }

        public Marksheet(string name, string fatherName, string phone, string mail, DateTime dob, Gender gender) : base(name, fatherName, phone, mail, dob, gender)
        {
        }


        public void Percentage()
        {
            double average=((double)ProjectMark/(6*100*4))*100;
            Console.WriteLine($"Average {average.ToString("0.00")}");
        }

        public void Total()
        {
            for(int i=0;i<6;i++){
                ProjectMark+=base.sem1[i]+base.sem2[i]+base.sem3[i]+base.sem4[i];
            }
            Console.WriteLine($"Total :{ProjectMark}");
        }
    }
}