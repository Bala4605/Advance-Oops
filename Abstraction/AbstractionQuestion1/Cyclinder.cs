using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AbstractionQuestion1
{
    public class Cyclinder : Shape
    {
        public override double Area { get;set; }
        public override double Volume { get;set; }

        public Cyclinder(Double radius,double height){
            base.Radius=radius;
            base.Height=height;
        }
        public override double CalculateArea()
        {   Area= 2*Math.PI*Radius*(Radius+Height);
            return Math.Round(Area,2);
        }

        public override double CalculateVolume()
        {   Volume=Math.PI*Radius*Radius*Height;
            return Math.Round(Volume,2) ;
        }
    }
}