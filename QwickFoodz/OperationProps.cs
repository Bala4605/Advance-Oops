using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QwickFoodz
{
    public static partial class Operations
    {
       public static CustomerDetails currentCustomer;
       public static List<CustomerDetails> customerList=new List<CustomerDetails>();
       public static List<FoodDetails> foodList=new List<FoodDetails>();
       public static List<OrderDetails> orderList=new List<OrderDetails>();
       public static List<ItemDetails> itemList=new List<ItemDetails>();
    }
}