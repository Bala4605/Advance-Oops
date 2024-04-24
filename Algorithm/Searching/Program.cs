using System;
using Sorting;
namespace Searching;
class Program{
    public static void Main(string[] args)
    {
        int[] intArray={45,33,12,55,77,22,33,14,67,78,22,11,44,66,88,12,35,84,93,77 };
        string[] strArray={"SF3023", "SF3021", "SF3067", "SF3043", "SF3053", "SF3032", "SF3063", "SF3089", "SF3062", "SF3092"};
        char[] charArray={'c','a','f','b','k','h','z','t','m','p','l','d'};
        double[] doubleArray={1.1,65.3,93.9,55.5,3.5,6.9};
        BubbleSort<int>.Sort(intArray);
        InsertionSort<string>.Sort(strArray);
        SelectionSort<char>.Sort(charArray);
        BubbleSort<double>.Sort(doubleArray);
        Console.WriteLine(BinarySearch<int>.Binary(intArray,66)>0);
        Console.WriteLine(BinarySearch<string>.Binary(strArray,"SF3067")>0);
        Console.WriteLine(LinearSearch<char>.Linear(charArray,'m')>0);
        Console.WriteLine(LinearSearch<double>.Linear(doubleArray,3.5)>0);
        

    }
}