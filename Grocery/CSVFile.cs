using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Grocery
{
    public static class CSVFile
    {
        public static void CreateFolder(){
            if(!Directory.Exists("Grocery")){
                Directory.CreateDirectory("Grocery");
            }
            if(!File.Exists("Grocery/ProductDetails.csv")){
                File.Create("Grocery/ProductDetails.csv").Close();
            }
             if(!File.Exists("Grocery/CustomerDetails.csv")){
                File.Create("Grocery/CustomerDetails.csv").Close();
            }
             if(!File.Exists("Grocery/OrderDetails.csv")){
                File.Create("Grocery/OrderDetails.csv").Close();
            }
             if(!File.Exists("Grocery/BookingDetails.csv")){
                File.Create("Grocery/BookingDetails.csv").Close();
            }
        }
        public static void ReadFromCSV(){
          string[] customers=File.ReadAllLines("Grocery/CustomerDetails.csv");
          string[] orders=File.ReadAllLines("Grocery/OrderDetails.csv");
          string[] products=File.ReadAllLines("Grocery/ProductDetails.csv");
          string[] books=File.ReadAllLines("Grocery/BookingDetails.csv");
          foreach(string customer in customers){
            string[] customer1=customer.Split(",");
            Operation.customerList.Add(new CustomerDetails(customer1[0],customer1[1],customer1[2],Enum.Parse<Gender>(customer1[3],true),customer1[4],DateTime.ParseExact(customer1[5],"dd/MM/yyyy",null),customer1[6],int.Parse(customer1[7])));
          }
          foreach(string order in orders){
            string[] order1=order.Split(",");
            Operation.orderList.Add(new OrderDetails(order1[0],order1[1],order1[2],int.Parse(order1[3]),int.Parse(order1[4])));

          }   

          foreach(string product in products){
            string[] product1=product.Split(",");
            Operation.productList.Add(new ProductDetails(product1[0],product1[1],int.Parse(product1[2]),int.Parse(product1[3])));

          } 
          foreach(string book in books){
            string[] book1=book.Split(",");
            Operation.bookingList.Add(new BookingDetails(book1[0],book1[1],int.Parse(book1[2]),DateTime.ParseExact(book1[3],"dd/MM/yyyy",null),Enum.Parse<BookingStatus>(book1[4],true)));

          } 

        }
        public static void WriteToCSV(){
          string[] customers=new string[Operation.customerList.Count],products=new string[Operation.productList.Count],books=new string[Operation.bookingList.Count],orders=new string[Operation.orderList.Count];
          int customerCount=0,productCount=0,bookCount=0,orderCount=0;
          foreach(CustomerDetails customer in Operation.customerList){
            customers[customerCount++]=$"{customer.CustomerID},{customer.Name},{customer.FatherName},{customer.Gender},{customer.Mobile},{customer.DOB.ToString("dd/MM/yyyy")},{customer.MailID},{customer.WalletBalance}";
          }
          foreach(ProductDetails product in Operation.productList){
            products[productCount++]=$"{product.ProductID},{product.ProductName},{product.QuantityAvailable},{product.PricePerQuantity}";
          }
          foreach(BookingDetails book in Operation.bookingList){
            books[bookCount++]=$"{book.BookingID},{book.CustomerID},{book.TotalPrice},{book.DateOfBooking.ToString("dd/MM/yyyy")},{book.BookingStatus}";
          }
          foreach(OrderDetails order in Operation.orderList){
            orders[orderCount++]=$"{order.OrderID},{order.BookingID},{order.ProductID},{order.PurchaseCount},{order.PriceOfOrder}";
          }
          File.WriteAllLines("Grocery/CustomerDetails.csv",customers);
          File.WriteAllLines("Grocery/OrderDetails.csv",orders);
          File.WriteAllLines("Grocery/ProductDetails.csv",products);
          File.WriteAllLines("Grocery/BookingDetails.csv",books);
        }
        
    }
}