using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AbstractionQuestion4
{
    public class Menswear : Dress
    {
        public override DressType DressType { get;set; }
        public override string DressName { get;set; }
        public override int Price { get;set; }
        public override int TotalPrice { get;set; }
        public Menswear(DressType dressType,string dressName,int price ){
            DressType=dressType;
            DressName=dressName;
            Price=price;
        }
        public override void DisplayInfo()
        {  Console.WriteLine($"{"DressType",-15} {"DressName",-15} {"Price",-15}");
           Console.WriteLine($"{DressType,-15} {DressName,-15} {Price,-15}");
        }

        public override void GetDressInfo()
        {
            Console.WriteLine($"Discounted  Amount :{Price*((double)70/100)}");
        }
    }
}