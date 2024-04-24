using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Searching
{
    public class LinearSearch<Type>
    {
        public static int Linear(Type[] array,Type a){
        for(int i=0;i<array.Length;i++){
            if(array[i].Equals(a)){
                return i;
            }
        }
        return -1;
       }
        
    }
}