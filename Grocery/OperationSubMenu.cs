using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Grocery
{
    public static partial class Operation
    {
        //Show Customer Details
        static void ShowCustomerDetails()
        {
            Console.WriteLine($"Customer ID :{currentLogged.CustomerID}");
            Console.WriteLine($"Name :{currentLogged.Name}");
            Console.WriteLine($"Father Name :{currentLogged.FatherName}");
            Console.WriteLine($"Gender :{currentLogged.Gender}");
            Console.WriteLine($"Mobile :{currentLogged.Mobile}");
            Console.WriteLine($"Mail :{currentLogged.MailID}");
            Console.WriteLine($"DOB :{currentLogged.DOB.ToShortDateString()}");
            Console.WriteLine($"Wallet Balance :{currentLogged.WalletBalance}");

        }
        //Show Product Details
        static void ShowProductDetails()
        {

            Console.WriteLine($"{"ProductID",-20}{"ProductName",-20}{"QuantityAvailable",-20}{"PricePerQuantity",-20}");

            foreach (ProductDetails product in productList)
            {
                if (product.QuantityAvailable > 0)
                {
                    Console.WriteLine($"{product.ProductID,-20}{product.ProductName,-20}{product.QuantityAvailable,-20}{product.PricePerQuantity,-20}");
                }
            }
        }
        //Wallet Recharge
        static void WalletRecharge()
        {
            Console.Write("Enter Amount :");
            int amount = int.Parse(Console.ReadLine());
            currentLogged.WalletRecharge(amount);

        }
        //Take Order
        static void TakeOrder()
        {
            Console.Write("Do you Want To Purchase?-(yes/no)");
            string value=Console.ReadLine().ToLower();
            if(value=="yes"){
                BookingDetails book=new BookingDetails(currentLogged.CustomerID,0,DateTime.Now,BookingStatus.Initiated);
                CustomList<OrderDetails> temp=new CustomList<OrderDetails>();
                string repeat="yes";
                int amount=0;
                while(repeat=="yes"){
                    ShowProductDetails();
                    Console.Write("Enter Product ID:");
                    string product=Console.ReadLine().ToUpper();
                    
                    foreach(ProductDetails i in productList){
                        if(i.ProductID==product){
                            Console.Write("Enter count:");
                            int count=int.Parse(Console.ReadLine());
                            if(count<=i.QuantityAvailable){
                                temp.Add(new OrderDetails(book.BookingID,i.ProductID,count,i.PricePerQuantity*count));
                                i.QuantityAvailable-=count;
                                amount+=i.PricePerQuantity*count;
                            }
                        }
                    }
                    Console.Write("Continue Purchase?-(yes/no)");
                    repeat=Console.ReadLine();
                    
                }
                Console.Write("Do you want to Confirm Order?-(yes/no)");
                if("yes"==Console.ReadLine().ToLower()){
                    if(currentLogged.WalletBalance>amount){
                        book.BookingStatus=BookingStatus.Booked;
                        book.TotalPrice=amount;
                        bookingList.Add(book);
                        currentLogged.Deduct(amount);
                        orderList.AddRange(temp);
                        Console.Write("Order Booked successfully");

                    }else{
                        Console.WriteLine($"Insufficient account balance recharge with {amount} ");
                        Console.Write("Do you Want to Recharge?-(yes/no)");
                        if("yes"==Console.ReadLine().ToLower()){
                            Console.Write("Enter Amount :");
                            currentLogged.WalletRecharge(int.Parse(Console.ReadLine()));
                             if(currentLogged.WalletBalance>amount){
                            book.BookingStatus=BookingStatus.Booked;
                            book.TotalPrice=amount;
                            bookingList.Add(book);
                            currentLogged.Deduct(amount);
                            orderList.AddRange(temp);
                            Console.Write("Order Booked successfully");

                    }else{
                        foreach(OrderDetails order in temp){
                            IncreaseCount(order.ProductID,order.PurchaseCount);
                        }
                    }
                    }
                    }
                }
                
            }


        }
        //Modify Order Quantity
        static void ModifyOrderQuantity()
        {
            foreach (BookingDetails book in bookingList)
            {
                if (book.CustomerID == currentLogged.CustomerID && book.BookingStatus == BookingStatus.Booked)
                {
                    Console.WriteLine($"{book.BookingID,-20}{book.CustomerID,-20}{book.TotalPrice,-20}{book.DateOfBooking.ToShortDateString(),-20}{book.BookingStatus,-20}");
                }
            }
            Console.Write("Enter Booking ID :");
            string bookingID = Console.ReadLine().ToUpper();
            Console.WriteLine($"{"OrderID",-20}{"BookingID",-20}{"ProductID",-20}{"PurchaseCount",-20}{"PriceOfOrder",-20}");
            foreach (OrderDetails order in orderList)
            {
                if (bookingID == order.BookingID)
                {
                    Console.WriteLine($"{order.OrderID,-20}{order.BookingID,-20}{order.ProductID,-20}{order.PurchaseCount,-20}{order.PriceOfOrder,-20}");
                }

            }
            Console.Write("Enter Product ID :");
            string productID = Console.ReadLine().ToUpper();
            Console.Write("Enter Count :");
            int count = int.Parse(Console.ReadLine());

            foreach(OrderDetails order in orderList){
                if(bookingID == order.BookingID && productID==order.ProductID){
                    count=count-order.PurchaseCount;
                    ReduceCount(order.ProductID,count,out int price);
                    order.PurchaseCount+=count;
                    order.PriceOfOrder+=price;
                    foreach(BookingDetails book in bookingList){
                        if(bookingID==order.BookingID){
                            book.TotalPrice+=price;
                        }
                    }

                }
            }

}
        // Cancel Order
        static void CancelOrder()
        {
            Console.WriteLine($"{"BookingID",-20}{"CustomerID",-20}{"TotalPrice",-20}{"DateOfBooking",-20}{"BookingStatus",-20}");

            foreach (BookingDetails book in bookingList)
            {
                if (book.CustomerID == currentLogged.CustomerID && book.BookingStatus == BookingStatus.Booked)
                {
                    Console.WriteLine($"{book.BookingID,-20}{book.CustomerID,-20}{book.TotalPrice,-20}{book.DateOfBooking,-20}{book.BookingStatus,-20}");
                }
            }
            Console.Write("Enter Booking ID :");
            string bookingID = Console.ReadLine().ToUpper();
            foreach (BookingDetails book in bookingList)
            {
                if (book.BookingID == bookingID && book.BookingStatus == BookingStatus.Booked)
                {
                    book.BookingStatus = BookingStatus.Cancelled;
                    currentLogged.WalletRecharge(book.TotalPrice);
                    foreach (ProductDetails product in productList)
                    {
                        foreach (OrderDetails order in orderList)
                        {
                            if (product.ProductID == order.ProductID && order.BookingID == book.BookingID)
                            {
                                product.QuantityAvailable += order.PurchaseCount;
                            }
                        }
                    }

                    Console.WriteLine("Booking cancelled successfully");
                }
            }
        }
        //ShowBalance
        static void ShowBalance()
        {
            Console.WriteLine($"Balance :{currentLogged.WalletBalance}");

        }
        static void ReduceCount(string pid,int count,out int value){
            value=0;
             foreach(ProductDetails i in productList){
                if(i.ProductID==pid){
                    i.QuantityAvailable-=count;
                    value=count*i.PricePerQuantity;
                    
                }
            }

        }
        static void IncreaseCount(string pid,int count){
            foreach(ProductDetails i in productList){
                if(i.ProductID==pid){
                    i.QuantityAvailable+=count;
                }
            }
        }
    }
}