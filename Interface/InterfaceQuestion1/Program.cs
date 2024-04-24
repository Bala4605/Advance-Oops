
using System;
namespace InterfaceQuestion1;
class Program{
    public static void Main(string[] args)
    {
        IAnimal dog=new Dog("Dog","Dog can Run","Dog eats Food");
        IAnimal duck=new Duck("Duck","Duck can Swim","Duck eats Food");
        dog.DisplayInfo();
        Console.WriteLine();
        duck.DisplayInfo();
    }

}