using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PartialClassQuestion2
{
    public partial class StudentInfo
    {   
        public void  TotalAndPercentage(){
            int total=Physics+Maths+Physics;
            Console.WriteLine($"Total:{total}  Average:{Math.Round((double)total/3,2)}");
        }
        public void Display(){
            Console.WriteLine($"{"EmployeeID",-15} {"Name",-15} {"Gender",-15} {"DOB",-15} {"Mobile",-15} {"Maths",-10} {"Physics",-10} {"Chemistry",-10} ");

            Console.WriteLine($"{StudentID,-15} {Name,-15} {Gender,-15} {DOB.ToShortDateString(),-15} {Mobile,-15} {Maths,-10} {Physics,-10} {Chemistry,-10}");
        }
    }
}