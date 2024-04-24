using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;

namespace MedicalStore
{
    public interface IWallet
    {
        public int WalletBalance{get;}
        void	WalletRecharge(int amount);
        void DeductBalance(int amount);

    }
}