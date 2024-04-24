using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AbstractionQuestion3
{  public enum EngineType{Petrol,Diesel,Cng}
  public enum CarType{Hatchback,Sedan, Suv}
    public abstract class Car
    {
        private int _noOfWheels=4, _noOfDoors = 4;
        public abstract EngineType EngineType{ get; set; }
        public abstract CarType CarType { get; set; }
        public abstract int NoOfSeats{ get; set; }
        public abstract int Price{ get; set; }

        //  get engine type, get no. of seats, get price, get car type, Display  car detail
        
        public abstract EngineType GetEngineType();
        public abstract CarType GetCarType();       
        public abstract int GetPrice();     
        public abstract int GetNoOfSeats();
        public abstract void DisplayCarDetail();
        public int ShowWheels(){
            return _noOfWheels;
        }
        public int ShowDoors(){
            return _noOfDoors;
        }
    }
}