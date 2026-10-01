//3 swap two numbers
using System;

class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("enter number a:");
        int a=int.Parse(Console.ReadLine());
        Console.WriteLine("enter number b:");
        int b=int.Parse(Console.ReadLine());
        int temp=a;
        a=b;
        b=temp;
        Console.WriteLine($"a:{a},b:{b}");
    }
}