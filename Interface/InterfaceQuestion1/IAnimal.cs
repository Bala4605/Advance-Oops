using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InterfaceQuestion1
{
    public interface IAnimal
    {
       string Name { get; set; }
       string Habit { get; set; }
       string EatingHabit { get; set; }

       void DisplayInfo();
    }
}