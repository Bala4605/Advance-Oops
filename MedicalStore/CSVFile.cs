using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace MedicalStore
{
    public static class CSVFile
    {
        public static void CreateFolder(){
            if(!Directory.Exists("MedicalStore")){
                Directory.CreateDirectory("MedicalStore");
            }
            if(!File.Exists("MedicalStore/UserDetails.csv")){
                File.Create("MedicalStore/UserDetails.csv").Close();
            }
            if(!File.Exists("MedicalStore/MedicineDetails.csv")){
                File.Create("MedicalStore/MedicineDetails.csv").Close();
            }
            if(!File.Exists("MedicalStore/orderDetails.csv")){
                File.Create("MedicalStore/orderDetails.csv").Close();
            }
        }
        public static void ReadFromCSV(){
           string[] users=File.ReadAllLines("MedicalStore/UserDetails.csv");
           string[] orders=File.ReadAllLines("MedicalStore/orderDetails.csv");
           string[] medicines=File.ReadAllLines("MedicalStore/MedicineDetails.csv");

           foreach(string user in users){
            string[] user1=user.Split(",");
            Operations.userList.Add(new UserDetails(user1[0],user1[1],int.Parse(user1[2]),user1[3],user1[4],int.Parse(user1[5])));
           }
           foreach(string medicine in medicines){
             string[] medicine1=medicine.Split(",");
            Operations.medicineList.Add(new MedicineDetails(medicine1[0],medicine1[1],int.Parse(medicine1[2]),int.Parse(medicine1[3]),DateTime.ParseExact(medicine1[4],"dd/MM/yyyy",null)));
           }
           foreach(string order in orders){
             string[] order1=order.Split(",");
            Operations.orderList.Add(new OrderDetails(order1[0],order1[1],order1[2],int.Parse(order1[3]),int.Parse(order1[4]),DateTime.ParseExact(order1[5],"dd/MM/yyyy",null),Enum.Parse<OrderStatus>(order1[6],true)));
           }
           
        }
        public static void WriteToCSV(){
           string[] users=new string[Operations.userList.Count] ;
           string[] orders=new string[Operations.orderList.Count] ;
           string[] medicines=new string[Operations.medicineList.Count] ;
           int userCount=0,orderCount=0,medicineCount=0;
           foreach(UserDetails user in Operations.userList){
                users[userCount++]=$"{user.UserID},{user.Name},{user.Age},{user.City},{user.PhoneNumber},{user.WalletBalance}";
           }
           foreach(MedicineDetails medicine in Operations.medicineList){
                medicines[medicineCount++]=$"{medicine.MedicineID},{medicine.MedicineName},{medicine.AvailableCount},{medicine.Price},{medicine.DateOfExpiry.ToString("dd/MM/yyyy")}";
           }
           foreach(OrderDetails order in Operations.orderList){
                orders[orderCount++]=$"{order.OrderID},{order.UserID},{order.MedicineID},{order.MedicineCount},{order.TotalPrice},{order.OrderDate.ToString("dd/MM/yyyy")},{order.OrderStatus}";
           }
           File.WriteAllLines("MedicalStore/UserDetails.csv",users);
           File.WriteAllLines("MedicalStore/MedicineDetails.csv",medicines);
           File.WriteAllLines("MedicalStore/orderDetails.csv",orders);
        }
        
    }
}