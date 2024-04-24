using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MedicalStore
{
    /// <summary>
    /// <see cref="PersonalDetails"/> Class
    /// </summary>
    public class PersonalDetails
    {
        /// <summary>
        /// Property Name
        /// </summary>
        /// <value></value>
     public string	Name{get;set;}
     /// <summary>
     /// Property Age
     /// </summary>
     /// <value></value>
    public int	Age{get;set;}
    /// <summary>
    /// Property City
    /// </summary>
    /// <value></value>
    public string	City{get;set;}
    /// <summary>
    /// Property Phonenumber
    /// </summary>
    /// <value></value>
    public string	PhoneNumber{get;set;}
    /// <summary>
    /// Constructor of <see cref="PersonalDetails"/> Class
    /// </summary>
    /// <param name="name"></param>
    /// <param name="age"></param>
    /// <param name="city"></param>
    /// <param name="phone"></param>
    public PersonalDetails(string name,int age,string city,string phone)
    {
        Name=name;
        Age=age;
        City=city;
        PhoneNumber=phone;
        
    }

        
    }
}