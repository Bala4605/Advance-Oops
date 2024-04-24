using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MultipleInheritanceQuestion2
{
    public enum FuelType{Petrol,Diesel};
    public class Car
    {
         public FuelType FuelType{get;set;}
         public int NumberOfSeats{get;set;}
         public string Color{get;set;}
         public int TankCapacity{get;set;}
         public int NumberOfKmDriven{get;set;}

         public Car(FuelType fuelType,int numberOfSeats,string color,int tankCapacity,int numberOfKmDriven){
            FuelType=fuelType;
            NumberOfSeats=numberOfSeats;
            Color=color;
            TankCapacity=tankCapacity;
            NumberOfKmDriven=numberOfKmDriven;
         }

         public int CalculateMilage(){
            return NumberOfKmDriven/TankCapacity;
         }
         
        
        
    }
}