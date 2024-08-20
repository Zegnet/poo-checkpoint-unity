using System;

class Program
{

    static void Main(string[] args)
    {
        //POLYMORPHISM EXAMPLE
        Animal cat = new Cat(4, true);
        Animal dog = new Dog(4, false);

        if (cat.GetHasHair())
            Console.WriteLine("The Cat Have Nice Hair");
        else
            Console.WriteLine("The Cat No Have Hair");

        Console.WriteLine("The Cat Have " + cat.GetPaws() + " Paws");

        dog.SetHasHair(true);

        if (dog.GetHasHair())
            Console.WriteLine("The Dog Have Nice Hair");
        else
            Console.WriteLine("The Dog No Have Hair");

        Console.WriteLine("The Dog Have " + dog.GetPaws() + " Paws");



    }
}