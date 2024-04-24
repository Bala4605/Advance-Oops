using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SealedQuestion3
{
    public class EmployeeInfo:FamilyInfo
    {
        public string EmployeeID{get;set;} 
        public string DateOfJoining {get;set;} 
        public override void Update(){
            // cannot override inherited member 'FamilyInfo.Update()' because it is sealed
        }
        public override void Display(){
            // cannot override inherited member 'FamilyInfo.Display()' because it is sealed
        }
    }
}