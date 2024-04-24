using System;
namespace HybridInheritanceQuestion1;
class Program{
    public static void Main(string[] args)
    {
        Marksheet mark=new Marksheet("Baskaran","Sethu","8167152899","baskar@gmail.com",new DateTime(1988,12,12),Gender.Male);
        mark.Total();
        mark.Percentage();
    }
}
