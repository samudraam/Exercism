//* Decorator NOTES:
//--------------------------------------------------------------------------------

/* Normally we just have classes:

using System;

public class Program
{
    public static void Main()
    {
        var dog = new Animal("Rex");
        dog.Speak();
    }
}

public class Animal
{
    private string _name;

    public Animal(string name)
    {
        _name = name;
    }

    public void Speak()
    {
        Console.WriteLine(_name + " makes a sound.");
    }
}

*/
//--------------------------------------------------------------------------------

//? BUT what if i want other types??
//! LETS USE DECORATORS

using System;

public class Program
{
    public static void Main()
    {
        IAnimal dog = new Animal("Rex");
        IAnimal cat = new Cat("Whiskers");
        IAnimal loudDog = new LoudAnimal(dog);
        IAnimal loudCat = new LoudAnimal(cat);
        IAnimal veryLoudDog = new LoudAnimal(new LoudAnimal(dog));  

        dog.Speak();
        cat.Speak();
        loudDog.Speak();
        loudCat.Speak();
        veryLoudDog.Speak();
    }
}
// An interface in C# is a code contract that defines a blueprint of methods and properties without any actual implementation. 
// It states what a class must do, but not how it does it.
//* ANIMAL MUST SPEAK
public interface IAnimal
{
    void Speak();
}

public class Animal : IAnimal
{
    private string _name;
    public Animal(string name) => _name = name;
    public void Speak() => Console.WriteLine(_name + " makes a sound.");
}

public class Cat : IAnimal
{
    private string _name;
    public Cat(string name) => _name = name;
    public void Speak() => Console.WriteLine(_name + " meows.");
}


//
public class LoudAnimal : IAnimal
{
    private readonly IAnimal _inner;
    public LoudAnimal(IAnimal inner) => _inner = inner;
    public void Speak()
    {
        _inner.Speak();
        Console.WriteLine("(but LOUDER)");
    }
}