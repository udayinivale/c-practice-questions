using System;
class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("enter number of seconds:");
        int seconds=int.Parse(Console.ReadLine());
        int hours=seconds/3600;
        int minutes=(seconds%3600)/60;
        int second=seconds%60;
        Console.WriteLine($"{hours} h {minutes} m {second} s");
    }
}