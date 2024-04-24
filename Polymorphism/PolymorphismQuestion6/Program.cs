using System;
namespace PolymorphismQuestion6;
class Program{
    public static void Main(string[] args)
    {
        Bank sbi=new SBI();
        Bank hdfc=new HDFC();
        Bank icici=new ICICI();
        Bank idbi=new IDBI();
        Console.WriteLine($" SBI {sbi.GetIntresetInfo()} %");
        Console.WriteLine($" HDFC {hdfc.GetIntresetInfo()} %");
        Console.WriteLine($" ICICI {icici.GetIntresetInfo()} %");
        Console.WriteLine($" IDBI {idbi.GetIntresetInfo()} %");

    }
}