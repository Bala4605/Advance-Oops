using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Searching
{
    public class BinarySearch<Type>
    {
       public static int Binary(Type[] array,Type a){
       
       int start=0;
       int end=array.Length-1;
       int value=-1;
       while(start<=end){
        int mid=(start+end)/2;

        if(array[mid].Equals(a)){
            value=mid;
            break;
        }else if(Comparer<Type>.Default.Compare(array[mid],a)>0){
            end=mid-1;
        }else{
            start=mid+1;
        }
       }
       return value;}
       
    }
}