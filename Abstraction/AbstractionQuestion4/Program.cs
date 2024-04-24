using System;
namespace AbstractionQuestion4;
class Program{
    public static void Main(string[] args)
    {
        Dress men=new Menswear(DressType.Menswear,"Shirt",500);
        Dress women=new Ladieswear(DressType.Ladieswear,"Chuti",900);
        
        men.DisplayInfo();
        men.GetDressInfo();
        Console.WriteLine();
        
        women.DisplayInfo();
        women.GetDressInfo();
       
    }
}