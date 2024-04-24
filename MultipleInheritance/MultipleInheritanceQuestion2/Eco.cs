using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MultipleInheritanceQuestion2
{
    public class Eco:Car,IBrand
    {
        private static int s_makingId=1001;
        public string BrandName {get;set;}
        public string ModelName {get;set;}
        public string MakingID{get;set;} 
        public int EngineNumber{get;set;} 
        public int ChasisNumber{get;set;} 
        

        public Eco(string brandName,string modelName,FuelType fuelType, int numberOfSeats, string color, int tankCapacity, int numberOfKmDriven,int engineNumber,int chasisNumber) : base(fuelType, numberOfSeats, color, tankCapacity, numberOfKmDriven)
        {
            MakingID="EID"+s_makingId++;
            EngineNumber=engineNumber;
            ChasisNumber=chasisNumber;
            BrandName=brandName;
            ModelName=modelName;
        }

        public void ShowDetails()
        {
            Console.WriteLine($"{"BrandName",-12} {"ModelName",-12} {"EngineNumber",-12} {"ChasisNumber",-12} {"FuelType",-12} {"NumberOfSeats",-12} {"Color",-12} {"TankCapacity",-12} {"NumberOfKmDriven",-12}");
             Console.WriteLine($"{BrandName,-12} {ModelName,-12} {EngineNumber,-12} {ChasisNumber,-12} {base.FuelType,-12} {base.NumberOfSeats,-12} {base.Color,-12} {base.TankCapacity,-12} {base.NumberOfKmDriven,-12}");
        }
    }
}