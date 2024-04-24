using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VirutalQuestion2
{
    public class Dimension
    {
        public int Value1 { get; set; }
        public int Value2 { get; set; }
        public double Area { get; set; }
        public Dimension(int value1,int value2){
            Value1=value1;
            Value2=value2;
        }
        public virtual void calculate(){
            Area=Value1*Value2;
        }
        public void Display(){
            Console.WriteLine($"Area :{Area}");
        }
        
    }
}