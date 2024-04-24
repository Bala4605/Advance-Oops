using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AbstractionQuestion3
{
    public class MarurthiSwift:Car
    {
        public override EngineType EngineType { get;set; }
        public override CarType CarType { get;set; }
        public override int NoOfSeats { get;set; }
        public override int Price { get;set; }
        public MarurthiSwift(EngineType engineType,CarType carType ,int noOfSeats,int price){
            EngineType=engineType;
            CarType=carType;
            NoOfSeats=noOfSeats;
            Price=price;
        }
      

        public override EngineType GetEngineType()
        {
            return EngineType;
        }

        public override CarType GetCarType()
        {
            return CarType;
        }

        public override int GetPrice()
        {
            return Price;
        }

        public override int GetNoOfSeats()
        {
            return NoOfSeats;
        }
        public override void DisplayCarDetail(){
            Console.WriteLine($"{"NOOfWheels",-15}{"NoOfDoors",-15}{"EngineType",-15}{"CarType",-15}{"NoOfSeats",-15}{"Price",-15}");
            Console.WriteLine($"{base.ShowWheels(),-15}{base.ShowDoors(),-15}{EngineType,-15}{CarType,-15}{NoOfSeats,-15}{Price,-15}");
        }
    }
}