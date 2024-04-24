using System;
namespace PolymorphismQuestion1;
class Program{
    public static void Main(string[] args)
    {
        Multiply(5);
        Multiply(5,6);
        Multiply(5,6,5);
        Multiply(5,0.5);
        Multiply(5,0.5,0.5);
        

    }
    static void Multiply(int value){
        Console.WriteLine(value*value);
    }
    static void Multiply(int value,int value1){
        Console.WriteLine(value*value1);
    }
    static void Multiply(int value,int value1,int value2){
        Console.WriteLine(value*value1*value2);
    }
    static void Multiply(int value,double value1){
        Console.WriteLine(value*value1);
    }
    static void Multiply(int value,double value1,double value2){
        Console.WriteLine(value*value1*value2);
    }
}