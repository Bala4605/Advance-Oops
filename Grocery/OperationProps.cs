using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Grocery
{
    public static partial class Operation
    {   
        public static CustomerDetails currentLogged;
        public static CustomList<CustomerDetails> customerList=new CustomList<CustomerDetails>(); 
        public static CustomList<ProductDetails> productList=new CustomList<ProductDetails>(); 
        public static CustomList<BookingDetails> bookingList=new CustomList<BookingDetails>(); 
        public static CustomList<OrderDetails> orderList=new CustomList<OrderDetails>(); 
    }
}