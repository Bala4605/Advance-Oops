using System;
namespace Sorting;
class Program{
    public static void Main(string[] args)
    {
        int[] intArray={45,33,12,55,77,22,33,14,67,12,35};
        string[] strArray={"SF3023", "SF3021", "SF3067", "SF3043", "SF3053", "SF3032", "SF3063", "SF3089", "SF3062", "SF3092"};
        char[] charArray={'c','a','f','b','k','h','z','t','m','p','l','d'};
        double[] doubleArray={1.1,65.3,93.9,55.5,3.5,6.9};
        BubbleSort<int>.Sort(intArray);
        InsertionSort<string>.Sort(strArray);
        SelectionSort<char>.Sort(charArray);
        BubbleSort<double>.DescendSort(doubleArray);
        InsertionSort<string>.DescendSort(strArray);
        
        foreach(int value in intArray){
            Console.Write($"{value} ");
           
        }
         Console.WriteLine();
        foreach(string value in strArray){
            Console.Write($"{value} ");
            
        }
        Console.WriteLine();
        foreach(char value in charArray){
            Console.Write($"{value} ");
            
        }
        Console.WriteLine();

        foreach(double value in doubleArray){
            Console.Write($"{value} ");
        }
         Console.WriteLine();
        foreach(string value in strArray){
            Console.Write($"{value} ");
            
        }
       
        
    }
}