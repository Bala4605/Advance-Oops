using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CalculatorApp
{
    public class CyclinderArea:CircleArea
    {
        private int _height;

        

        public int Height{get {return _height;}set{_height=value;}}
        internal double Voume{get;set;}
        public CyclinderArea(double radius,int height) : base(radius)
        {
            Height=height;
        }
        
         public void CalculateVolume(){
            Console.WriteLine($"{base.CalculateCircleArea()*_height}");
         }
    }
}