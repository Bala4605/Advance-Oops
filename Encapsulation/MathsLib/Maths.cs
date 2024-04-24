using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Threading.Tasks;

namespace MathsLib
{
    public class Maths
    {
        protected internal double PI=3.14;
        internal double g=9.8;
        public void calculateWeight(){
            Console.Write("Enter Mass :");
            Console.WriteLine(int.Parse(Console.ReadLine())*g);
        }
        
    }
}