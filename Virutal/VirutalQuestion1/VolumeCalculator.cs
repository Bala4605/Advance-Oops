using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VirutalQuestion1
{
    public class VolumeCalculator : AreaCalculator
    {   public int Height{get;set;}
        public VolumeCalculator(int radius,int height) : base(radius)
        {
            Height=height;
        }
        public override void Calculate()
        {
            Console.WriteLine($"Volume :{Math.Round(3.14*base.Radius*base.Radius*Height,2)}");
        }
    }
}