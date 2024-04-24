using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SealedQuestion4
{
    public class CircleCalculator : Calculator
    {
        public double Area1 { get; set; }
        public sealed override double Area(int radius)
        {
            Area1=3.14*Math.Pow(radius,2);
            return Area1;
        }

        
    }
}