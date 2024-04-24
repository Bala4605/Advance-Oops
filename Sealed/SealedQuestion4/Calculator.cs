using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SealedQuestion4
{
    public abstract class Calculator
    {
       public abstract double Area(int radius); 
       public virtual double Volume(int radius,int height){
            double Volume=Area(radius)*height;
            return Volume;
       }
    }
}