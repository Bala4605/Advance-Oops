
using System;
namespace VirutalQuestion2;
class Program{
    public static void Main(string[] args)
    {
        Dimension dimension=new Dimension(10,20);
        dimension.calculate();
        dimension.Display();
        Rectangle rectangle=new Rectangle(12,20);
        rectangle.calculate();
        rectangle.Display();
        Sphere sphere=new Sphere(10);
        sphere.calculate();
        sphere.Display();
        
    }
}