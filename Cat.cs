using System;

public class Cat : Animal
{

    //ENCAPSULATION EXAMPLE
    private int paws;
    private Boolean hasHair;

    public Cat(int _paws, Boolean _hasHair)
    {
        paws = _paws;
        hasHair = _hasHair;
    }

    public override bool GetHasHair()
    {
        return hasHair;
    }

    public override int GetPaws()
    {
        return paws;
    }

    public override void Jump()
    {
        Console.WriteLine("Cat is Jumping");
    }

    public override void Run()
    {
        Console.WriteLine("Cat is Running");
    }

    public override void SetHasHair(bool _hasHair)
    {
        hasHair = _hasHair;
    }

    public override void SetPaws(int _paws)
    {
        paws = _paws;
    }

    public override void Walk()
    {
        Console.WriteLine("Cat is Walking");
    }
}