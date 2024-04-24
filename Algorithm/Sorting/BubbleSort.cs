using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sorting
{
    public static class BubbleSort<Type>
    {
        public static void Sort(Type[] array)
        {
            int count = 1;
            while (count != 0)
            {
                count = 0;
                for (int i = 0; i < array.Length - 1; i++)
                {
                    if (Comparer<Type>.Default.Compare(array[i], array[i + 1]) > 0)
                    {
                        Type temp = array[i];
                        array[i] = array[i + 1];
                        array[i + 1] = temp;
                        count++;
                    }
                }
            }
        }

        public static void DescendSort(Type[] array)
        {
            int count = 1;
            while (count != 0)
            {
                count = 0;
                for (int i = 0; i < array.Length - 1; i++)
                {
                    if (Comparer<Type>.Default.Compare(array[i], array[i + 1]) < 0)
                    {
                        Type temp = array[i];
                        array[i] = array[i + 1];
                        array[i + 1] = temp;
                        count++;
                    }
                }
            }
        }
    }
}
