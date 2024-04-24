using System;
namespace VirutalQuestion1;
class Program{
    public static void Main(string[] args)
    {
        AreaCalculator area =new AreaCalculator(24);
        VolumeCalculator volume =new VolumeCalculator(13,12);
        area.Calculate();
        volume.Calculate();
    }
}