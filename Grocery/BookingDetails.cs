using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Grocery
{
    public enum BookingStatus{Default, Initiated, Booked, Cancelled}
    /// <summary>
    /// Booking Details Class
    /// </summary>
    public class BookingDetails
    {
        /// <summary>
        /// static field stores bookingID count
        /// </summary>
        private static int s_bookingID=3000;
        /// <summary>
        /// Booking ID
        /// </summary>
        /// <value></value>
        public string BookingID {get;set;} 
        /// <summary>
        /// CustomerID
        /// </summary>
        /// <value></value>
        public string CustomerID{get;set;} 
        /// <summary>
        /// TotalPrice
        /// </summary>
        /// <value></value>
        public int TotalPrice{get;set;} 
        /// <summary>
        /// DateOfBooking
        /// </summary>
        /// <value></value>
        public DateTime DateOfBooking{get;set;} 
        /// <summary>
        /// BookingStatus
        /// </summary>
        /// <value></value>
        public BookingStatus BookingStatus{get;set;}
        /// <summary>
        /// Constructor of <see cref="BookingDetails"/>
        /// </summary>
        /// <param name="customerID"></param>
        /// <param name="totalPrice"></param>
        /// <param name="dateOfBooking"></param>
        /// <param name="bookingStatus"></param>
        public BookingDetails(string customerID,int totalPrice,DateTime dateOfBooking,BookingStatus bookingStatus)
        {
            BookingID="BID"+ ++s_bookingID;
            CustomerID=customerID;
            TotalPrice=totalPrice;
            DateOfBooking=dateOfBooking;
            BookingStatus=bookingStatus;
        }
        public BookingDetails(string bookingID,string customerID,int totalPrice,DateTime dateOfBooking,BookingStatus bookingStatus)
        {
            BookingID=bookingID;
            CustomerID=customerID;
            TotalPrice=totalPrice;
            DateOfBooking=dateOfBooking;
            BookingStatus=bookingStatus;
            s_bookingID=int.Parse(bookingID.Remove(0,3));

        }
        
    }
}