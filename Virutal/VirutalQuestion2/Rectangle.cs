using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VirutalQuestion2
{
    public class Rectangle:Dimension
    {
        public int Length { get; set; }
        public int Height { get; set; }
        public Rectangle(int height,int length):base(0,0){
            Length=length;
            Height=height;
        }
        public override void calculate(){
            Area=Height*Length;
        }



        
    }
}