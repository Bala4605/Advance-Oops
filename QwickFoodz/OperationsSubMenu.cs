using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Transactions;

namespace QwickFoodz
{
    public static partial class Operations
    {
    public static void ShowProfile(){
        Console.WriteLine($"\nCustomerID :{currentCustomer.CustomerID}");
        Console.WriteLine($"Name :{currentCustomer.Name}");
        Console.WriteLine($"Father Name :{currentCustomer.FatherName}");
        Console.WriteLine($"Gender :{currentCustomer.Gender}");
        Console.WriteLine($"Mobile :{currentCustomer.Mobile}");
        Console.WriteLine($"DOB :{currentCustomer.DOB.ToShortDateString()}");
        Console.WriteLine($"MailID :{currentCustomer.MailID}");
        

    }
        public static void OrderFood()
        {
            
            OrderDetails order1=new OrderDetails(currentCustomer.CustomerID,0,DateTime.Now,OrderStatus.Initiated);
            List<ItemDetails> local=new List<ItemDetails>();
            string repeat="yes";
            int totalAmount=0;
            while(repeat=="yes"){
            ShowFoodMenu();
            Console.Write("Enter Food ID :");
            string foodID=Console.ReadLine().ToUpper();
            Console.Write("Enter Quantity :");
            int quantity=int.Parse(Console.ReadLine());
            if(ValidID(foodID)){
                
                    DecreaseCount(foodID,quantity,out int price);
                    local.Add(new ItemDetails(order1.OrderID,foodID,quantity,price));
                    totalAmount+=price;

                
            }else{
                Console.WriteLine("Invalid Food ID !!!!");
            }
            Console.Write("Do you want to add more?-(yes/no) :");
            repeat=Console.ReadLine().ToLower();
            }

            Console.Write("Do you want to confirm purchase?-(yes/no) :");
            if("yes"==Console.ReadLine().ToLower()){
                if(currentCustomer.WalletBalance>totalAmount){
                    currentCustomer.DeductBalance(totalAmount);
                    order1.TotalPrice=totalAmount;
                    order1.OrderStatus=OrderStatus.Ordered;
                    itemList.AddRange(local);
                    orderList.Add(order1);
                    Console.WriteLine("Ordered Place Successfully");

                }else{
                    Console.WriteLine($"Insufficent Balance.Please Recharge Above {totalAmount}");
                    Console.Write("Do you Wnat To Recharge?-(yes/no) :");

                    if("yes"==Console.ReadLine().ToLower()){
                        Console.Write("Enter Amount :");
                        int amount=int.Parse(Console.ReadLine());
                        currentCustomer.WalletRecharge(amount);
                        currentCustomer.DeductBalance(totalAmount);
                        order1.TotalPrice=totalAmount;
                        order1.OrderStatus=OrderStatus.Ordered;
                        itemList.AddRange(local);
                        orderList.Add(order1);
                        Console.WriteLine("Ordered Place Successfully");
                        
                    }
                }

            }else{
                foreach(ItemDetails item in local){
                    IncreaseCount(item.FoodID,item.PurchaseCount);
                }
            }
        }
        public static void CancelOrder()
        {
            Console.WriteLine($"\n{"OrderID",-15} {"CustomerID",-15} {"TotalPrice",-15} {"DateOfOrder",-15} {"OrderStatus",-15}");

            foreach (OrderDetails order in orderList)
            {
                if (order.CustomerID == currentCustomer.CustomerID && order.OrderStatus == OrderStatus.Ordered)
                {
                    Console.WriteLine($"{order.OrderID,-15} {order.CustomerID,-15} {order.TotalPrice,-15} {order.DateOfOrder.ToShortDateString(),-15} {order.OrderStatus,-15}");
                }
            }
            Console.Write("Enter ID :");
            string orderID = Console.ReadLine().ToUpper();
            foreach (OrderDetails order in orderList)
            {
                if (order.OrderID == orderID)
                {
                    order.OrderStatus = OrderStatus.Cancelled;
                    currentCustomer.WalletRecharge(order.TotalPrice);
                    foreach (ItemDetails item in itemList)
                    {
                        if (item.OrderID == order.OrderID)
                        {
                            IncreaseCount(item.FoodID, item.PurchaseCount);
                        }
                    }
                }
            }


        }
        public static void ModifyOrder()
        {
            bool flag = false;
            Console.WriteLine($"\n{"OrderID",-15} {"CustomerID",-15} {"TotalPrice",-15} {"DateOfOrder",-15} {"OrderStatus",-15}");

            foreach (OrderDetails order in orderList)
            {
                if (order.CustomerID == currentCustomer.CustomerID && order.OrderStatus == OrderStatus.Ordered)
                {
                    Console.WriteLine($"{order.OrderID,-15} {order.CustomerID,-15} {order.TotalPrice,-15} {order.DateOfOrder.ToShortDateString(),-15} {order.OrderStatus,-15}");
                }
            }
            Console.Write("Enter ID :");
            string orderID = Console.ReadLine().ToUpper();
            Console.WriteLine($"\n{"FoodID",-20}{"PurchaseCount",-20}{"PriceOfOrder",-20}");
            foreach (ItemDetails item in itemList)
            {
                if (item.OrderID == orderID)
                {
                    Console.WriteLine($"{item.FoodID,-20}{item.PurchaseCount,-20}{item.PriceOfOrder,-20}");
                    flag = true;
                }
            }
            if (flag)
            {
                Console.Write("Enter Product ID :");
                string productId = Console.ReadLine().ToUpper();
                Console.Write("Enter new Product Count :");
                int count = int.Parse(Console.ReadLine());
                foreach (ItemDetails item in itemList)
                {
                    if (item.OrderID == orderID && item.FoodID == productId)
                    {
                        int newCount = count - item.PurchaseCount;
                        if(IsQuantityAvalible(item.FoodID,newCount)){
                        DecreaseCount(item.FoodID, newCount, out int price);
                        item.PriceOfOrder += price;
                        item.PurchaseCount = count;
                        if (currentCustomer.WalletBalance > price)
                        {
                            currentCustomer.DeductBalance(price);
                            foreach (OrderDetails order in orderList)
                            {
                                if (order.OrderID == item.OrderID)
                                {
                                    order.TotalPrice += price;
                                    Console.WriteLine($"Order ID {order.OrderID} modified successfully");
                                }
                            }
                        }
                        else
                        {
                            Console.WriteLine($"Insufficent Balance.Please Recharge Above {price}");
                        }
                        }else{
                            Console.WriteLine($"Quantity Not Available .");
                        }
                    }
                }


            }


        }
        public static void OrderHistory()
        {
            Console.WriteLine($"{"OrderID",-15} {"CustomerID",-15} {"TotalPrice",-15} {"DateOfOrder",-15} {"OrderStatus",-15}");

            foreach (OrderDetails order in orderList)
            {
                if (order.CustomerID == currentCustomer.CustomerID)
                {
                    Console.WriteLine($"{order.OrderID,-15} {order.CustomerID,-15} {order.TotalPrice,-15} {order.DateOfOrder.ToShortDateString(),-15} {order.OrderStatus,-15}");
                }
            }
        }
        public static void RechargeWallet()
        {
            Console.Write("Enter Amount :");
            int amount = int.Parse(Console.ReadLine());
            currentCustomer.WalletRecharge(amount);

        }
        public static void	ShowWalletBalance(){
        Console.WriteLine($"Balance: {currentCustomer.WalletBalance}");
        }
        static void DecreaseCount(string foodID, int count, out int price)
        {
            price = 0;
            foreach (FoodDetails food in foodList)
            {
                if (food.FoodID == foodID)
                {
                    food.QuantityAvailable -= count;
                    price = food.PricePerQuantity * count;
                }
            }
        }
        static void IncreaseCount(string foodID, int count)
        {
            foreach (FoodDetails food in foodList)
            {
                if (food.FoodID == foodID)
                {
                    food.QuantityAvailable += count;

                }
            }
        }
        static bool IsQuantityAvalible(string foodID,int count){
            foreach(FoodDetails food in foodList){
                if(food.FoodID==foodID){
                    return food.QuantityAvailable>=count;
                }
            }
            return false;
        }
        static void ShowFoodMenu(){
            Console.WriteLine("---------------------------------------------------------------------------------------");
            Console.WriteLine($"{"FoodID",-15}| {"FoodName",-25}| {"PricePerQuantity",-20}| {"QuantityAvailable",-20}|");
            Console.WriteLine("---------------------------------------------------------------------------------------");

  
            foreach(FoodDetails food in foodList){
                Console.WriteLine($"{food.FoodID,-15}| {food.FoodName,-25}| {food.PricePerQuantity,-20}| {food.QuantityAvailable,-20}|");
                Console.WriteLine("---------------------------------------------------------------------------------------");

            }

        }
        static bool ValidID(string foodID){
            foreach(FoodDetails food in foodList){
                if(food.FoodID==foodID){
                    return true;
                }
            }
            return false;
        }
        
    }
}