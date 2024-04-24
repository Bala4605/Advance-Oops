using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SealedQuestion4
{
    public class CylinderCalculator : Calculator
    {
        
        public override double Area(int radius)
        {
            return 3.14*radius*radius;
            
        }
        public override double Volume(int radius,int height){
            return Area(radius)*height;
        }

        
    }
}