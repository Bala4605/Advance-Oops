using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Grocery
{
    public interface IBalance
    {
       int WalletBalance { get; set; }
       void WalletRecharge(int amount);
    }
}