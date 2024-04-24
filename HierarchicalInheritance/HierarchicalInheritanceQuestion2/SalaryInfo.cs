using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HierarchicalInheritanceQuestion2
{
    public class SalaryInfo
    {
        public int BasicSalary{get;set;}
        public int  Month{get;set;}
        public SalaryInfo( int basicSalary,int  month){
            BasicSalary=basicSalary;
            Month=month;
        }
    }
}