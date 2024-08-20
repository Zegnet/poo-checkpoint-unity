using System;

//ABSTRACTION EXAMPLE
public abstract class Animal
{

    public abstract void SetPaws(int _paws);
    public abstract int GetPaws();
    public abstract void SetHasHair(Boolean _hasHair);
    public abstract bool GetHasHair();
    public abstract void Walk();
    public abstract void Run();
    public abstract void Jump();
}