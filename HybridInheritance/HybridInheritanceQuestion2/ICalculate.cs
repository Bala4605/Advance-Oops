using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HybridInheritanceQuestion2
{
    public interface ICalculate
    {
         void Deposit(int amount);
         void Withdraw(int amount);
         void BalanceCheck();
    }
}