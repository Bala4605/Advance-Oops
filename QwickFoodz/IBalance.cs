using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QwickFoodz
{
    public interface IBalance
    {
        public int WalletBalance { get; }
        void WalletRecharge(int amount);
        void DeductBalance(int amount);
    }
}