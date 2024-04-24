using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VirutalQuestion1
{
    public class AreaCalculator
    {
        public int Radius { get; set; }
        public AreaCalculator(int radius){
            Radius=radius;
        }
        public virtual void Calculate(){
            Console.WriteLine($"Area :{Math.Round(3.14 *Radius*Radius,2)}");
        }
    }
}