using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sorting
{
    public class SelectionSort<Type>
    {
        public static void Sort(Type[] array)
        {
            for (int j = 0; j < array.Length; j++)
            {
                Type min = array[j];
                int index = j;
                for (int i = j; i < array.Length; i++)
                {
                    if (Comparer<Type>.Default.Compare(min, array[i]) > 0)
                    {
                        min = array[i];
                        index = i;
                    }
                }
                Type temp = array[j];
                array[j] = min;
                array[index] = temp;
            }
        }
         public static void DescendSort(Type[] array)
        {
            for (int j = 0; j < array.Length; j++)
            {
                Type min = array[j];
                int index = j;
                for (int i = j; i < array.Length; i++)
                {
                    if (Comparer<Type>.Default.Compare(min, array[i]) < 0)
                    {
                        min = array[i];
                        index = i;
                    }
                }
                Type temp = array[j];
                array[j] = min;
                array[index] = temp;
            }
        }
    }
}