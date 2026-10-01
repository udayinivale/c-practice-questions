using System;
class Animal
{
    public virtual void sound()
    {
        Console.WriteLine("some sound");
    }
}
class Dog : Animal
{
    public override void sound()
    {
        Console.WriteLine("woof");
    }
}
class Cat : Animal
{
    public override void sound()
    {
        Console.WriteLine("meow");
    }
}
class Cow : Animal
{
    public override void sound()
    {
        Console.WriteLine("moo");
    }
}
class Program
{
    static void Main()
    {
        Animal a1=new Dog();
        Animal a2=new Cat();
        Animal a3=new Cow();
        a1.sound();
        a2.sound();
        a3.sound();
    }
}