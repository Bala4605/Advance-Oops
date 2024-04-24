using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace PolymorphismQuestion8
{
    public class Calculator
    {
        public static void Calculate(Semester sem){
            int total=sem.Subject1+sem.Subject2+sem.Subject3+sem.Subject4+sem.Subject5+sem.Subject6;
            double average=((double)total/(6*100*6))*100;
            Console.WriteLine($"Total :{total} Average :{average.ToString("0.00")}");
        }
    }
}