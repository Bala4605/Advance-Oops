using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HybridInheritanceQuestion1
{
    public interface ICalculate
    {
        public int  ProjectMark { get; set; }
        void Total();
        void Percentage();
    }
}