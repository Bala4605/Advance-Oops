using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QwickFoodz
{
    public enum OrderStatus{Default, Initiated, Ordered, Cancelled}
    public class OrderDetails
    {
        private static int s_orderID=3000;
        public string OrderID {get;set;} 
        public string CustomerID {get;set;} 
        public int TotalPrice {get;set;} 
        public DateTime DateOfOrder {get;set;} 
        public OrderStatus OrderStatus {get;set;} 

        public OrderDetails(string customerID,int totalPrice,DateTime dateOfOrder,OrderStatus orderStatus )
        {
            OrderID="OID"+ ++s_orderID;
            CustomerID=customerID;
            TotalPrice=totalPrice;
            DateOfOrder=dateOfOrder;
            OrderStatus=orderStatus;
            
        }
        public OrderDetails(string orderID,string customerID,int totalPrice,DateTime dateOfOrder,OrderStatus orderStatus )
        {
            OrderID=orderID;
            CustomerID=customerID;
            TotalPrice=totalPrice;
            DateOfOrder=dateOfOrder;
            OrderStatus=orderStatus;
            s_orderID=int.Parse(orderID.Remove(0,3));
            
        }
        
    }
}