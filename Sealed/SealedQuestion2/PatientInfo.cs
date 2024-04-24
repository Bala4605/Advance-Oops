using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SealedQuestion2
{
    public sealed class PatientInfo
    {
        public string PatientID{get;set;} 
        public string Name{get;set;} 
        public string FatherName{get;set;} 
        public int BedNo{get;set;} 
        public string NativePlace{get;set;} 
        public string AdmittedFor{get;set;} 

        void Display(){
            Console.WriteLine($"{PatientID}{Name}{FatherName}{BedNo}{NativePlace}{AdmittedFor}");
        }
    }
}