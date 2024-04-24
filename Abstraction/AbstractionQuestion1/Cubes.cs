using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AbstractionQuestion1
{
    public class Cubes : Shape
    {
        public override double Area { get;set;}
        public override double Volume { get;set;}
        public Cubes(double a){
            base.A=a;
        }
        public override double CalculateArea()
        {   Area= (double)(6*Math.Pow(A,2));
            return Math.Round(Area,2);
        }

        public override double CalculateVolume()
        {   Volume=Math.Pow(A,3);
            return Math.Round(Volume,2) ;
        }
    }
}