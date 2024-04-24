using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MultiLevelInheritanceQuestion1
{
    public class HSCDetails : StudentInfo
    {
        // HSCMarksheetNumber, Physics, Chemistry, Maths, Total, Percentage marks
        private static int s_hscNumber=1001;
        public string HSCMarksheetNumber { get; set; }
        public int Physics { get; set; }
        public int Chemistry { get; set; }
        public int Maths { get; set; }
        public double Total{ get; set; }
        public double PercentageMarks{ get; set; }
        public HSCDetails(string name, string fatherName, string phone, string mail, DateTime dob, Gender gender, int standard, string branch, int acadamicYear,string registerNumber,int physics,int chemistry,int maths) : base(name, fatherName, phone, mail, dob, gender, standard, branch, acadamicYear,registerNumber)
        {
            HSCMarksheetNumber="HSC"+s_hscNumber;
            Physics=physics;
            Chemistry=chemistry;
            Maths=maths;
            Total=Math.Round((double)Physics+Chemistry+Maths,2);
            PercentageMarks=Math.Round((double)Total/3,2);

        }
        public void TotalAndAverage(){
           Console.WriteLine($"Total :{Total} Percent :{PercentageMarks}");
        }
        public void ShowMarkSheet(){
            Console.WriteLine($"{"Physics",-15} {"Chemistry",-15} {"Maths",-15} {"Total",-15} {"PercentageMarks",-15}");
            Console.WriteLine($"{Physics,-15} {Chemistry,-15} {Maths,-15} {Total,-15} {PercentageMarks,-15}");
        }
    }
}