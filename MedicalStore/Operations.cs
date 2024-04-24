using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MedicalStore
{
    public class Operations
    {
        public static UserDetails currentUser;
        public static CustomList<UserDetails> userList=new CustomList<UserDetails>();
        public static CustomList<MedicineDetails> medicineList=new CustomList<MedicineDetails>();
        public static CustomList<OrderDetails> orderList=new CustomList<OrderDetails>();
        public static void AddDefault(){
            userList.AddRange(new CustomList<UserDetails>{
                new UserDetails("Ravi",33,"Theni","9877774440",400),
                new UserDetails("Baskaran",33,"Chennai","9877774440",500)
            });
            medicineList.AddRange(new CustomList<MedicineDetails>{
                new MedicineDetails("Paracitamol",40,5,new DateTime(2024,6,30)),
                new MedicineDetails("Calpol",10,5,new DateTime(2024,5,30)),
                new MedicineDetails("Gelucil",3,40,new DateTime(2024,4,30)),
                new MedicineDetails("Metrogel",5,50,new DateTime(2024,12,30)),
                new MedicineDetails("Povidin Iodin",10,50,new DateTime(2024,10,30)),
            });
            orderList.AddRange(new CustomList<OrderDetails>{
                new OrderDetails("UID1001","MD101",3,15,new DateTime(2022,11,30),OrderStatus.Purchased),
                new OrderDetails("UID1001","MD102",2,10,new DateTime(2022,11,30),OrderStatus.Cancelled),
                new OrderDetails("UID1001","MD104",2,100,new DateTime(2022,11,30),OrderStatus.Purchased),
                new OrderDetails("UID1002","MD103",3,120,new DateTime(2022,11,15),OrderStatus.Cancelled),
                new OrderDetails("UID1002","MD105",5,250,new DateTime(2022,11,15),OrderStatus.Purchased),
                new OrderDetails("UID1002","MD102",3,15,new DateTime(2022,11,15),OrderStatus.Purchased)
            });
        }
    
            public static void MainMenu(){
            int choice=1;
            while(choice!=3){
                Console.WriteLine();
                Console.WriteLine("-----------MAIN MENU---------");
                Console.WriteLine("\n1. User Registration\n2. User Login\n3. Exit");
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

            Console.Write("Enter Your Name :");
             string name=Console.ReadLine();
            Console.Write("Enter Your Age :");
            int age=int.Parse(Console.ReadLine());
            Console.Write("Enter Your City :");
            string city=Console.ReadLine();
            Console.Write("Enter Your PhoneNumber :");
            string phoneNumber=Console.ReadLine();
            Console.Write("Enter Amount :");
            int walletBalance=int.Parse(Console.ReadLine());
            UserDetails user=new UserDetails(name,age,city,phoneNumber,walletBalance);
            Console.WriteLine($"Your ID is {user.UserID}");

        }
        public static void  Login(){
            Console.Write("Enter UserID :");
            string userID=Console.ReadLine().ToUpper();
            bool flag=false;
            foreach(UserDetails user in userList){
                if(user.UserID==userID){
                    currentUser=user;
                    flag=true;

                }
            }
            if(flag){
            int subChoice=1;
            while(subChoice!=8){
                Console.WriteLine();
                Console.WriteLine("-----------SUB MENU---------");
                Console.WriteLine("\n1. Show medicine list\n2. Purchase medicine\n3. Modify purchase\n4. Cancel purchase\n5. Show purchase history\n6. Recharge Wallet\n7. Show Wallet Balance\n8. Exit");
                Console.Write("Enter Your Choice: ");
                subChoice=int.Parse(Console.ReadLine());
                switch(subChoice){
                    case 1:{
                        ShowMedicineList();
                        break;
                    }
                    case 2:{
                        PurchaseMedicine();
                        break;
                    }
                    case 3:{
                        ModifyPurchase();
                        break;
                    }
                    case 4:{
                        CancelPurchase();
                        break;
                    }
                    case 5:{
                        ShowPurchaseHistory();
                        break;
                    }
                    case 6:{
                        RechargeWallet();
                        break;
                    }
                    case 7:{
                        ShowWalletBalance();
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
            }else{
                Console.WriteLine("Invalid ID!!!!");
            }
        }

        private static void ShowWalletBalance()
        {
            Console.WriteLine($"\nBalance {currentUser.WalletBalance}");
        }

        private static void RechargeWallet()
        {
            Console.Write("Enter Amount :");
            int amount=int.Parse(Console.ReadLine());
            currentUser.WalletRecharge(amount);
            
        }

        private static void ShowPurchaseHistory()
        {
            Console.WriteLine($"{"OrderID",-15}{"UserID",-15}{"MedicineID",-15}{"MedicineCount",-15}{"TotalPrice",-15}{"OrderDate",-15}{"OrderStatus",-15}");

            foreach(OrderDetails order in orderList){
                if(currentUser.UserID==order.UserID){
                    Console.WriteLine($"{order.OrderID,-15}{order.UserID,-15}{order.MedicineID,-15}{order.MedicineCount,-15}{order.TotalPrice,-15}{order.OrderDate.ToString("dd/MM/yyyy"),-15}{order.OrderStatus,-15}");
                }
            }
        }

        private static void CancelPurchase()
        {
            Console.WriteLine($"{"OrderID",-15}{"UserID",-15}{"MedicineID",-15}{"MedicineCount",-15}{"TotalPrice",-15}{"OrderDate",-15}{"OrderStatus",-15}");

            foreach(OrderDetails order in orderList){
                if(currentUser.UserID==order.UserID && order.OrderStatus==OrderStatus.Purchased){
                    Console.WriteLine($"{order.OrderID,-15}{order.UserID,-15}{order.MedicineID,-15}{order.MedicineCount,-15}{order.TotalPrice,-15}{order.OrderDate.ToString("dd/MM/yyyy"),-15}{order.OrderStatus,-15}");
                }
            }
            Console.Write("Enter Order ID :");
            string orderID=Console.ReadLine().ToUpper();
            foreach(OrderDetails order in orderList){
                if(orderID==order.OrderID){
                    foreach(MedicineDetails medicine in medicineList){
                        if(medicine.MedicineID==order.MedicineID){
                            medicine.AvailableCount+=order.MedicineCount;
                            currentUser.WalletRecharge(order.TotalPrice);
                            order.OrderStatus=OrderStatus.Cancelled;
                            Console.WriteLine($"OrderID {order.OrderID} was cancelled successfully");
                        }
                    }
                }
            }
            
        }

        private static void ModifyPurchase()
        {
            Console.WriteLine($"{"OrderID",-15}{"UserID",-15}{"MedicineID",-15}{"MedicineCount",-15}{"TotalPrice",-15}{"OrderDate",-15}{"OrderStatus",-15}");

            foreach(OrderDetails order in orderList){
                if(currentUser.UserID==order.UserID && order.OrderStatus==OrderStatus.Purchased){
                    Console.WriteLine($"{order.OrderID,-15}{order.UserID,-15}{order.MedicineID,-15}{order.MedicineCount,-15}{order.TotalPrice,-15}{order.OrderDate.ToString("dd/MM/yyyy"),-15}{order.OrderStatus,-15}");
                }
            }
            Console.Write("Enter Order ID :");
            string orderID=Console.ReadLine().ToUpper();
            foreach(OrderDetails order in orderList){
                if(orderID==order.OrderID){
                //   int amount=order.TotalPrice/order.MedicineCount;  
                  Console.Write("Enter new Quantity :");
                  int newQuantity=int.Parse(Console.ReadLine());
                  int count=newQuantity-order.MedicineCount;
                  

                  foreach(MedicineDetails medicine in medicineList){
                        if(medicine.MedicineID==order.MedicineID){
                            if(currentUser.WalletBalance>(count*medicine.Price)){
                            medicine.AvailableCount-=count;
                            currentUser.DeductBalance(count*medicine.Price);
                            order.TotalPrice+=(count*medicine.Price);
                            order.MedicineCount=newQuantity;
                            Console.WriteLine("order modified successfully");
                            }
                            else{
                                Console.WriteLine("Recharge and Try .");
                            }

                        }
                        }
                  
                }
            }
        }

        private static void PurchaseMedicine()
        {
            ShowMedicineList();
            Console.Write("Enter Medicine ID :");
            string medicineID=Console.ReadLine().ToUpper();
            Console.Write("Enter Quantity :");
            int quantity=int.Parse(Console.ReadLine());
            foreach(MedicineDetails medicine in medicineList){
                if(medicine.MedicineID==medicineID){
                    if(medicine.AvailableCount>=quantity){
                        if(medicine.DateOfExpiry>DateTime.Now){
                            if((medicine.Price*quantity)<currentUser.WalletBalance){
                                currentUser.DeductBalance((medicine.Price*quantity));
                                medicine.AvailableCount-=quantity;
                                orderList.Add(new OrderDetails(currentUser.UserID,medicine.MedicineID,quantity,medicine.Price*quantity,DateTime.Now,OrderStatus.Purchased));
                                Console.WriteLine("Medicine was purchased successfully");
                            }
                        }else{
                        Console.WriteLine("Medicine Not Available.");
                        }
                    }else{
                        Console.WriteLine("Quantity Not Available.");
                    }
                }
            }
        }

        public static void ShowMedicineList(){
            Console.WriteLine($"{"MedicineID",-20}{"MedicineName",-20}{"AvailableCount",-20}{"Price",-20}{"DateOfExpiry",-20}");

            foreach(MedicineDetails medicine in medicineList){
                Console.WriteLine($"{medicine.MedicineID,-20}{medicine.MedicineName,-20}{medicine.AvailableCount,-20}{medicine.Price,-20}{medicine.DateOfExpiry.ToString("dd/MM/yyyy"),-20}");
            }

        }
    }
}