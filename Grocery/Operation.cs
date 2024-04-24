using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Grocery
{
    public static partial class Operation
    {
        public static void AddDefault(){
            customerList.AddRange(new CustomList<CustomerDetails>{
                new CustomerDetails("Ravi","Ettapparajan",Gender.Male,"974774646",new DateTime(1999,11,11),"ravi@gmail.com",10000),
                new CustomerDetails("Ravi","Ettapparajan",Gender.Male,"974774646",new DateTime(1999,11,11),"ravi@gmail.com",15000)
            });
            productList.AddRange(new CustomList<ProductDetails>{
                new ProductDetails("Suger",20,40),
                new ProductDetails("Rice",100,50),
                new ProductDetails("Milk",10,40),
                new ProductDetails("Coffee",10,10),
                new ProductDetails("Tea",10,10),
                new ProductDetails("Masala Powder",10,20),
                new ProductDetails("salt",10,10),
                new ProductDetails("Turmeric Powder",10,25),
                new ProductDetails("Chilli Powder",10,20),
                new ProductDetails("Groundnut Oil",10,140)
               
            });
            bookingList.AddRange(new CustomList<BookingDetails>{
                new BookingDetails("CID1001",220,new DateTime(2022,07,26),BookingStatus.Booked),
                new BookingDetails("CID1002",400,new DateTime(2022,07,26),BookingStatus.Booked),
                new BookingDetails("CID1001",280,new DateTime(2022,07,26),BookingStatus.Cancelled),
                new BookingDetails("CID1002",0,new DateTime(2022,07,26),BookingStatus.Initiated),
            });
            orderList.AddRange(new CustomList<OrderDetails>{
                new OrderDetails("BID3001","PID2001",2,	80),
                new OrderDetails("BID3001","PID2002",2,	100),
                new OrderDetails("BID3001","PID2003",1,	40),
                new OrderDetails("BID3002","PID2001",1,	40),
                new OrderDetails("BID3002","PID2002",4,	200),
                new OrderDetails("BID3002","PID2010",1,	140),
                new OrderDetails("BID3002","PID2009",1,	20),
                new OrderDetails("BID3003","PID2002",2,	100),
                new OrderDetails("BID3003","PID2008",4,	100),
                new OrderDetails("BID3003","PID2001",2,	80),
            });
        }
         public static void MainMenu(){
            Console.WriteLine("-------------------Welcomes to Online Grocery Shop-------------------");
            int choice=1;
            while(choice!=3){
                Console.WriteLine();
                Console.WriteLine("-----------MAIN MENU---------");
                Console.WriteLine();
                Console.WriteLine("1. Customer Registration\n2. Customer Login\n3. Exit");
                Console.Write("Enter Your Choice: ");
                choice=int.Parse(Console.ReadLine());
                switch(choice){
                    case 1:{
                        CustomerRegistration();
                        break;
                    }
                    case 2:{
                        Login();
                        break;
                    }
                   
                    case 3:{
                        choice=3;
                        Console.WriteLine("------- Exited Application SuccessFully --------");
                        break;
                    }
                    default:{
                        Console.WriteLine("Invalid Option !!!");
                        Console.WriteLine("Please Enter Valid option :");

                        break;
                    }
                }
            }

        }
        public static void CustomerRegistration(){
            Console.Write("Enter Your Name :");
            string name=Console.ReadLine();
            Console.Write("Enter Your FatherName :");
            string fatherName=Console.ReadLine();
            Console.Write("Enter Your Gender :");
            Gender gender=Enum.Parse<Gender>(Console.ReadLine(),true);
            Console.Write("Enter Your Mobile :");
            string mobile=Console.ReadLine();
            Console.Write("Enter Your DOB(dd/MM/yyyy) :");
            DateTime dob=DateTime.ParseExact(Console.ReadLine(),"dd/MM/yyyy",null);
            Console.Write("Enter Your MailID :");
            string mailID=Console.ReadLine();
            Console.Write("Enter Amount :");
            int balance=int.Parse(Console.ReadLine());
            CustomerDetails customer=new CustomerDetails(name,fatherName,gender,mobile,dob,mailID,balance);
            customerList.Add(customer);
            Console.WriteLine($"Your Customer ID: {customer.CustomerID}");
        }
        
        public static void  Login(){
            Console.Write("Enter Customer ID :");
            string id=Console.ReadLine().ToUpper();
            bool flag=false;
            foreach(CustomerDetails customer in customerList){
                if(id==customer.CustomerID){
                    flag=true;
                    currentLogged=customer;
                }
            }
            if(flag){
            int subChoice=1;
            while(subChoice!=8){
                Console.WriteLine();
                Console.WriteLine("-----------SUB MENU---------");
                
                Console.WriteLine("\n1. Show Customer Details\n2. Show Product Details\n3. Wallet Recharge\n4. Take Order\n5. Modify Order Quantity\n6. Cancel Order\n7. Show Balance\n8. Exit");
                Console.Write("Enter Your Choice: ");
                subChoice=int.Parse(Console.ReadLine());
                switch(subChoice){
                    case 1:{
                        ShowCustomerDetails();
                        break;
                    }
                    case 2:{
                        ShowProductDetails();
                        break;
                    }
                    case 3:{
                        WalletRecharge();
                        break;
                    }
                    case 4:{
                        TakeOrder();
                        break;
                    }
                    case 5:{
                        ModifyOrderQuantity();
                        break;
                    }
                    case 6:{
                        CancelOrder();
                        break;
                    }
                    case 7:{
                        ShowBalance();
                        break;
                    }
                    case 8:{
                        Console.WriteLine("---------- Log Out Successfully-----------");
                        subChoice=8;
                        break;
                    }
                    default:{
                        Console.WriteLine("Invalid Choice!!!!! Please Enter a Valid One .");
                       
                        break;
                    }
                }

            }

        }
        else{
            Console.WriteLine("Invalid UserID !!!");
        }
    }
        
    
    }
}