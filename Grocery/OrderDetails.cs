using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Grocery
{
    /// <summary>
    /// <see cref="OrderDetails"/> Class
    /// </summary>
    public class OrderDetails
    {
        /// <summary>
        /// s_orderID
        /// </summary>
        private static int s_orderID=4000;
        /// <summary>
        /// OrderID
        /// </summary>
        /// <value></value>
        public string OrderID {get;set;} 
        /// <summary>
        /// BookingID
        /// </summary>
        /// <value></value>
        public string BookingID{get;set;} 
        /// <summary>
        /// ProductID
        /// </summary>
        /// <value></value>
        public string ProductID{get;set;} 
        /// <summary>
        /// PurchaseCount
        /// </summary>
        /// <value></value>
        public int PurchaseCount{get;set;} 
        /// <summary>
        /// PriceOfOrder
        /// </summary>
        /// <value></value>
        public int PriceOfOrder{get;set;} 
        /// <summary>
        /// Constructor Of<see cref="OrderDetails"/>
        /// </summary>
        /// <param name="bookingID"></param>
        /// <param name="productID"></param>
        /// <param name="purchaseCount"></param>
        /// <param name="priceOfOrder"></param>
        public OrderDetails(string bookingID,string productID,int purchaseCount,int priceOfOrder)
        {
            OrderID="OID"+ ++s_orderID;
            BookingID=bookingID;
            ProductID=productID;
            PurchaseCount=purchaseCount;
            PriceOfOrder=priceOfOrder;
            
        }
        public OrderDetails(string orderID,string bookingID,string productID,int purchaseCount,int priceOfOrder)
        {
            OrderID=orderID;
            BookingID=bookingID;
            ProductID=productID;
            PurchaseCount=purchaseCount;
            PriceOfOrder=priceOfOrder;
            s_orderID=int.Parse(orderID.Remove(0,3));
            
        }
        
    }
}