using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Grocery
{
    /// <summary>
    /// <see cref="ProductDetails"/> Class
    /// </summary>
    public class ProductDetails
    {
        /// <summary>
        /// s_productID
        /// </summary>
        private static int s_productID=2000;
        /// <summary>
        /// ProductID
        /// </summary>
        /// <value></value>
        public string ProductID {get;set;} 
        /// <summary>
        /// ProductName
        /// </summary>
        /// <value></value>
        public string ProductName{get;set;} 
        /// <summary>
        /// QuantityAvailable
        /// </summary>
        /// <value></value>
        public int QuantityAvailable{get;set;} 
        /// <summary>
        /// PricePerQuantity
        /// </summary>
        /// <value></value>
        public int PricePerQuantity{get;set;} 
        /// <summary>
        /// Constructor of<see cref="ProductDetails"/>
        /// </summary>
        /// <param name="productName"></param>
        /// <param name="quantityAvailable"></param>
        /// <param name="pricePerQuantity"></param> <summary>
        /// 
        /// </summary>
        /// <param name="productName"></param>
        /// <param name="quantityAvailable"></param>
        /// <param name="pricePerQuantity"></param>
        public ProductDetails(string productName,int quantityAvailable,int pricePerQuantity)
        {
            ProductID="PID"+ ++s_productID;
            ProductName=productName;
            QuantityAvailable=quantityAvailable;
            PricePerQuantity=pricePerQuantity;
            
        }
        public ProductDetails(string productID,string productName,int quantityAvailable,int pricePerQuantity)
        {
            ProductID=productID;
            ProductName=productName;
            QuantityAvailable=quantityAvailable;
            PricePerQuantity=pricePerQuantity;
            s_productID=int.Parse(productID.Remove(0,3));
            
        }
        
       
    }
}