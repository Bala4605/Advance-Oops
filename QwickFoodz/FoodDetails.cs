using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QwickFoodz
{
    public class FoodDetails
    {
        private static int s_foodID=2000;
        public string FoodID{get;} 
        public string FoodName{get;set;} 
        public int PricePerQuantity{get;set;} 
        public int QuantityAvailable{get;set;} 
        public FoodDetails(string foodName,int pricePerQuantity,int quantityAvailable)
        {
            FoodID="FID"+ ++s_foodID;
            FoodName=foodName;
            PricePerQuantity=pricePerQuantity;
            QuantityAvailable=quantityAvailable;
            
        }
        public FoodDetails(string foodID,string foodName,int pricePerQuantity,int quantityAvailable)
        {
            FoodID=foodID;
            FoodName=foodName;
            PricePerQuantity=pricePerQuantity;
            QuantityAvailable=quantityAvailable;
            s_foodID=int.Parse(foodID.Remove(0,3));
            
        }

        
        
    }
}