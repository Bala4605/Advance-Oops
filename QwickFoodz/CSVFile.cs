using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.IO;
using System.Data.Common;

namespace QwickFoodz
{
    public static class CSVFile 
    {
        
        public static void CreateFolder(){
            if(!Directory.Exists("QwickFoodz")){
                Directory.CreateDirectory("QwickFoodz");
            }
            if(!File.Exists("QwickFoodz/CustomerDetails.csv")){
                File.Create("QwickFoodz/CustomerDetails.csv").Close();
            }
            if(!File.Exists("QwickFoodz/FoodDetails.csv")){
                File.Create("QwickFoodz/FoodDetails.csv").Close();
            }
            if(!File.Exists("QwickFoodz/OrderDetails.csv")){
                File.Create("QwickFoodz/OrderDetails.csv").Close();
            }
            if(!File.Exists("QwickFoodz/ItemDetails.csv")){
                File.Create("QwickFoodz/ItemDetails.csv").Close();
            }
        }

        public static void WriteToCSV(){
            string[] customers=new string[Operations.customerList.Count];
            string[] foods=new string[Operations.foodList.Count];
            string[] orders=new string[Operations.orderList.Count];
            string[] items=new string[Operations.itemList.Count];
            int customerCount=0,foodCount=0,orderCount=0,itemCount=0;
            foreach(CustomerDetails customer in Operations.customerList){
                customers[customerCount++]=$"{customer.CustomerID},{customer.Name},{customer.FatherName},{customer.Gender},{customer.Mobile},{customer.DOB.ToString("dd/MM/yyyy")},{customer.MailID},{customer.Location},{customer.WalletBalance}";
            }
            foreach(FoodDetails food in Operations.foodList){
                foods[foodCount++]=$"{food.FoodID},{food.FoodName},{food.PricePerQuantity},{food.QuantityAvailable}";
            }
            foreach(OrderDetails order in Operations.orderList){
                orders[orderCount++]=$"{order.OrderID},{order.CustomerID},{order.TotalPrice},{order.DateOfOrder.ToString("dd/MM/yyyy")},{order.OrderStatus}";
            }
            foreach(ItemDetails item in Operations.itemList){
                items[itemCount++]=$"{item.ItemID},{item.OrderID},{item.FoodID},{item.PurchaseCount},{item.PriceOfOrder}";
            }
            File.WriteAllLines("QwickFoodz/CustomerDetails.csv",customers);
            File.WriteAllLines("QwickFoodz/FoodDetails.csv",foods);
            File.WriteAllLines("QwickFoodz/OrderDetails.csv",orders);
            File.WriteAllLines("QwickFoodz/ItemDetails.csv",items);
        }
        public static void ReadFromCSV(){
            string[] customers=File.ReadAllLines("QwickFoodz/CustomerDetails.csv");
            string[] foods=File.ReadAllLines("QwickFoodz/FoodDetails.csv");
            string[] orders=File.ReadAllLines("QwickFoodz/OrderDetails.csv");
            string[] items=File.ReadAllLines("QwickFoodz/ItemDetails.csv");

            foreach(string customer in customers){
                string[] customer1=customer.Split(",");
                CustomerDetails customerDetail=new CustomerDetails(customer1[0],customer1[1],customer1[2],Enum.Parse<Gender>(customer1[3],true),customer1[4],DateTime.ParseExact(customer1[5],"dd/MM/yyyy",null),customer1[6],customer1[7],int.Parse(customer1[8]));
                Operations.customerList.Add(customerDetail);
            }
            foreach(string food in foods){
                string[] food1=food.Split(",");
                FoodDetails foodDetail=new FoodDetails(food1[0],food1[1],int.Parse(food1[2]),int.Parse(food1[3]));
                Operations.foodList.Add(foodDetail);
            }
            foreach(string order in orders){
                string[] order1=order.Split(",");
                OrderDetails orderDetail=new OrderDetails(order1[0],order1[1],int.Parse(order1[2]),DateTime.ParseExact(order1[3],"dd/MM/yyyy",null),Enum.Parse<OrderStatus>(order1[4],true));
                Operations.orderList.Add(orderDetail);
            }
            foreach(string item in items){
                string[] item1=item.Split(",");
                ItemDetails itemDetail=new ItemDetails(item1[0],item1[1],item1[2],int.Parse(item1[3]),int.Parse(item1[4]));
                Operations.itemList.Add(itemDetail);

            }
        }
    }
}