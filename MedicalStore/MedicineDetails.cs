using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MedicalStore
{
    /// <summary>
    /// <see cref="MedicineDetails"/> Class
    /// </summary>
    public class MedicineDetails
    {
    /// <summary>
    /// static s_medicineID
    /// </summary>
    private static int s_medicineID=100;
    /// <summary>
    /// MedicineID
    /// </summary>
    /// <value></value>
    public string MedicineID {get;set;}
    /// <summary>
    /// MedicineName
    /// </summary> <summary>
    /// 
    /// </summary>
    /// <value></value>
    public string MedicineName{get;set;}
    /// <summary>
    /// AvailableCount
    /// </summary>
    /// <value></value>
    public int AvailableCount{get;set;}
    /// <summary>
    /// Price
    /// </summary>
    /// <value></value>
    public int Price{get;set;}
    /// <summary>
    /// DateOfExpiry
    /// </summary>
    /// <value></value>
    public DateTime DateOfExpiry{get;set;}
    /// <summary>
    /// Constructor of <see cref="MedicineDetails"/> Class
    /// </summary>
    /// <param name="medicineName"></param>
    /// <param name="availableCount"></param>
    /// <param name="price"></param>
    /// <param name="dateOfExpiry"></param>
    public MedicineDetails(string medicineName,int availableCount,int price,DateTime dateOfExpiry)
    {
        MedicineID="MD"+ ++s_medicineID;
        MedicineName=medicineName;
        AvailableCount=availableCount;
        Price=price;
        DateOfExpiry=dateOfExpiry;

        
    }
    /// <summary>
    /// Constructor of <see cref="MedicineDetails"/> Class
    /// </summary>
    public MedicineDetails(string medicineID,string medicineName,int availableCount,int price,DateTime dateOfExpiry)
    {
        MedicineID=medicineID;
        MedicineName=medicineName;
        AvailableCount=availableCount;
        Price=price;
        DateOfExpiry=dateOfExpiry;
        s_medicineID=int.Parse(medicineID.Remove(0,3));

        
    }

        
    }
}