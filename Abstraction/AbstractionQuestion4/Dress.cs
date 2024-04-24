using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AbstractionQuestion4
{ public enum DressType{
Ladieswear, Menswear, Childrenswear
}
    public abstract class Dress
    {
        public abstract DressType DressType { get; set; }
        public abstract string DressName{ get; set; }
        public abstract int Price { get; set; }
        public abstract int TotalPrice { get; set; }
        public abstract void GetDressInfo();
        public abstract void DisplayInfo();
        
    }
}