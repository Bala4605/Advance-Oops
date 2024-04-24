using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MedicalStore
{
    public enum  OrderStatus {Purchased, Cancelled}
    /// <summary>
    /// <see cref="OrderDetails"/> Class
    /// </summary>
    public class OrderDetails
    {
    /// <summary>
    /// static s_orderID
    /// </summary>
    private static int s_orderID=2000;
    /// <summary>
    /// OrderID
    /// </summary>
    /// <value></value>
    public string OrderID {get;set;}
    /// <summary>
    /// UserID
    /// </summary>
    /// <value></value>
    public string UserID{get;set;}
     /// <summary>
     /// MedicineID
     /// </summary>
     /// <value></value>
    public string MedicineID{get;set;} 
    /// <summary>
    /// MedicineCount
    /// </summary>
    /// <value></value>
    public int MedicineCount{get;set;} 
    /// <summary>
    /// TotalPrice
    /// </summary>
    /// <value></value>
    public int TotalPrice{get;set;} 
    /// <summary>
    /// OrderDate
    /// </summary>
    /// <value></value>
    public DateTime OrderDate{get;set;} 
    /// <summary>
    /// OrderStatus
    /// </summary>
    /// <value></value>
    public OrderStatus OrderStatus {get;set;}
    /// <summary>
    /// Comstructor of <see cref="OrderDetails"/> Class
    /// </summary>
    /// <param name="userID"></param>
    /// <param name="medicineID"></param>
    /// <param name="medicineCount"></param>
    /// <param name="totalPrice"></param>
    /// <param name="orderDate"></param>
    /// <param name="orderStatus"></param> <summary>
    /// 
    /// </summary>
    /// <param name="userID"></param>
    /// <param name="medicineID"></param>
    /// <param name="medicineCount"></param>
    /// <param name="totalPrice"></param>
    /// <param name="orderDate"></param>
    /// <param name="orderStatus"></param>
    public OrderDetails(string userID,string medicineID,int medicineCount,int totalPrice,DateTime orderDate, OrderStatus orderStatus)
    {
        OrderID="OID"+ ++s_orderID;
        UserID=userID;
        MedicineID=medicineID;
        MedicineCount=medicineCount;
        TotalPrice=totalPrice;
        OrderDate=orderDate;
        OrderStatus=orderStatus;
        
    }
    ///<summary>
    /// Comstructor of <see cref="OrderDetails"/> Class
    /// </summary>
     public OrderDetails(string orderID,string userID,string medicineID,int medicineCount,int totalPrice,DateTime orderDate, OrderStatus orderStatus)
    {
        OrderID=orderID;
        UserID=userID;
        MedicineID=medicineID;
        MedicineCount=medicineCount;
        TotalPrice=totalPrice;
        OrderDate=orderDate;
        OrderStatus=orderStatus;
        s_orderID=int.Parse(orderID.Remove(0,3));
        
    }
        
    }
}