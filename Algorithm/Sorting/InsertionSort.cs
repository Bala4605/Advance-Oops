using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sorting
{
    public class InsertionSort<Type>
    {
        public static void Sort(Type[] array)
        {
            for (int j = 1; j < array.Length; j++)
            {
                for (int i = j; i > 0; i--)
                {
                    if (Comparer<Type>.Default.Compare(array[i], array[i-1]) < 0)
                    {
                        Type temp = array[i];
                        array[i] = array[i -1];
                        array[i - 1] = temp;

                    }
                }
            }
        }
         public static void DescendSort(Type[] array)
        {
            for (int j = 1; j < array.Length; j++)
            {
                for (int i = j; i > 0; i--)
                {
                    if (Comparer<Type>.Default.Compare(array[i], array[i-1]) > 0)
                    {
                        Type temp = array[i];
                        array[i] = array[i -1];
                        array[i - 1] = temp;

                    }
                }
            }
        }

    }
}