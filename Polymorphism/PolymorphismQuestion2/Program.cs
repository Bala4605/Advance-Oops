using System;
namespace InterfaceQuestion1;
class Program{
    public static void Main(string[] args)
    {
        Square(5);
        Square(5.89F);
        Square(5.78);
        Square(9786112059);

    }
    static void Square(int value){
        Console.WriteLine(value*value);
    }
     static void Square(float value){
        Console.WriteLine(value*value);
    }
     static void Square(double value){
        Console.WriteLine(value*value);
    }
     static void Square(long value){
        Console.WriteLine(value*value);
    }
}