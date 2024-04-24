using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InterfaceQuestion1
{
    public class Duck : IAnimal
    {
        public string Name {get;set;}

        public string Habit {get;set;}

        public string EatingHabit {get;set;}
        public Duck(string name,string habit,string eatingHabit){
        Name=name;
        Habit=habit;
        EatingHabit=eatingHabit;
        }
         public void DisplayInfo()
        {   Console.WriteLine($"{"Name",-10} {"Habit",-20} {"EatingHabit",-20}");
            Console.WriteLine($"{Name,-10} {Habit,-20} {EatingHabit,-20}");
        } 
    }
}