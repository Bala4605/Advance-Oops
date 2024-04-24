using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace QwickFoodz
{
    public static  partial class Operations
    {
        public static void AddDefaultdata()
        {
            CustomerDetails customer1 = new CustomerDetails("Ravi", "Ettapparajan", Gender.Male, "974774646", new DateTime(1999, 11, 11), "ravi@gmail.com", "chennai",10000);
            CustomerDetails customer2 = new CustomerDetails("Baskaran", "Sethurajan", Gender.Male, "847575775", new DateTime(1999, 11, 11), "baskaran@gmail.com", "chennai",15000);
            customerList.Add(customer1);
            customerList.Add(customer2);
            foodList.AddRange(new List<FoodDetails>{
            new FoodDetails("Chicken Briyani 1Kg",100,12),
            new FoodDetails("Mutton Briyani 1Kg",150,10),
            new FoodDetails("Veg Full Meals",80,30),
            new FoodDetails("Noodles",100,40),
            new FoodDetails("Dosa",40,40),
            new FoodDetails("Idly (2 pieces)",20,50),
            new FoodDetails("Pongal",40,20),
            new FoodDetails("Vegetable Briyani",80,15),
            new FoodDetails("Lemon Rice",50,30),
            new FoodDetails("Veg Pulav",120,30),
            new FoodDetails("Chicken 65 (200 Grams) ",75,30),
        });
            OrderDetails order1 = new OrderDetails(customer1.CustomerID, 580, new DateTime(2022, 11, 26), OrderStatus.Ordered);
            OrderDetails order2 = new OrderDetails(customer2.CustomerID, 870, new DateTime(2022, 11, 26), OrderStatus.Ordered);
            OrderDetails order3 = new OrderDetails(customer1.CustomerID, 820, new DateTime(2022, 11, 26), OrderStatus.Cancelled);
            orderList.AddRange(
                new List<OrderDetails> { order1, order2, order3 }
            );
            itemList.AddRange(
                new List<ItemDetails>{
                new ItemDetails(order1.OrderID,"FID2001",2,200),
                new ItemDetails(order1.OrderID,"FID2002",2,300),
                new ItemDetails(order1.OrderID,"FID2003",1,80),
                new ItemDetails(order2.OrderID,"FID2001",1,100),
                new ItemDetails(order2.OrderID,"FID2002",4,600),
                new ItemDetails(order2.OrderID,"FID2010",1,120),
                new ItemDetails(order2.OrderID,"FID2009",1,50),
                new ItemDetails(order3.OrderID,"FID2002",2,300),
                new ItemDetails(order3.OrderID,"FID2008",4,320),
                new ItemDetails(order3.OrderID,"FID2001",2,200),

             }
            );
            
            
        }

         public static void MainMenu(){
            Console.WriteLine("-----------------------QWICK FOODZ Welcomes You----------------------");
            int choice=1;
            while(choice!=3){
                Console.WriteLine();
                Console.WriteLine("-----------MAIN MENU---------");
                Console.WriteLine("\n1. Customer Registration\n2. Customer Login\n3. Exit");
                Console.Write("Enter Your Choice: ");
                choice=int.Parse(Console.ReadLine());
                switch(choice){
                    case 1:{
                        UserRegistration();
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
        public static void UserRegistration(){
            Console.Write("Enter Your Name:");
            string name=Console.ReadLine();
            Console.Write("Enter Your FatherName:");
            string fatherName=Console.ReadLine();
            Console.Write("Enter Your Gender:");
            Gender gender=Enum.Parse<Gender>(Console.ReadLine(),true);
            Console.Write("Enter Your Mobile Number:");
            string mobile=Console.ReadLine();
            Console.Write("Enter Your DOB:");
            DateTime dob=DateTime.ParseExact(Console.ReadLine(),"dd/MM/yyyy",null);
            Console.Write("Enter Your MailID:");
            string mailID=Console.ReadLine();
            Console.Write("Enter Your Location:");
            string location=Console.ReadLine();
            
            CustomerDetails customer=new CustomerDetails(name,fatherName,gender,mobile,dob,mailID,location);
            customerList.Add(customer);
            Console.WriteLine($"Customer registration successful Your Customer ID: {customer.CustomerID}");
            
            
        }
        public static void Login()
        {
            Console.Write("Enter Customer ID:");
            string customerID = Console.ReadLine().ToUpper();
            bool flag = false;
            foreach (CustomerDetails customer in customerList)
            {
                if (customer.CustomerID == customerID)
                {
                    flag = true;
                    currentCustomer = customer;
                }
            }
            if (flag)
            {
                int subChoice = 1;
                while (subChoice != 8)
                {
                    Console.WriteLine();
                    Console.WriteLine("-----------SUB MENU---------");
                    Console.WriteLine("\n1. Show Profile\n2. Order Food\n3. Cancel Order\n4. Modify Order \n5. Order History\n6. Recharge Wallet\n7. Show Wallet Balance\n8. Exit");
                    Console.Write("Enter Your Choice: ");
                    subChoice = int.Parse(Console.ReadLine());
                    switch (subChoice)
                    {
                        case 1:
                            {
                                ShowProfile();
                                break;
                            }
                        case 2:
                            {
                                OrderFood();
                                break;
                            }
                        case 3:
                            {
                                CancelOrder();
                                break;
                            }
                        case 4:
                            {
                                ModifyOrder();
                                break;
                            }
                        case 5:
                            {
                                OrderHistory();
                                break;
                            }
                        case 6:
                            {
                                RechargeWallet();
                                break;
                            }
                        case 7:
                            {
                                ShowWalletBalance();
                                break;
                            }
                        case 8:
                            {
                                Console.WriteLine("---------- Log Out Successfully-----------");
                                subChoice = 8;
                                break;
                            }
                        default:
                            {
                                Console.WriteLine("Invalid Choice!!!!! Please Enter a Valid One .");
                                break;
                            }
                    }
                }
            }
            else
            {
                Console.WriteLine("Invalid Customer ID !!!");
            }

        }


    }
}