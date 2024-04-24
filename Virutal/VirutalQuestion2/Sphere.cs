using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VirutalQuestion2
{
    public class Sphere:Dimension
    {
        
        public int Radius { get; set; }
        public Sphere(int radius):base(0,0){
            Radius=radius;
        }
        public override void calculate(){
            Area=4*3.14*Radius*Radius;
        }
        
    }
}