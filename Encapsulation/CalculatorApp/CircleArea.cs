using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MathsLib;

namespace CalculatorApp
{
    public class CircleArea:Maths
    {
    protected double radius;
    public double Radius{ get{return radius;}set{radius=value;}}  
    internal double Area{get;set;} 
    public CircleArea(double radius)
    {
        Radius=radius;
    }
    public double CalculateCircleArea(){
        return base.PI*radius*radius;
    }
    }
}