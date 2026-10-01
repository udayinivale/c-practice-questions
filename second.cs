//2 area and perimeter 
using System;

class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("enter width:");
        int width=int.Parse(Console.ReadLine());
        Console.WriteLine("enter height:");
        int height=int.Parse(Console.ReadLine());
        Console.WriteLine("area:"+(width*height));
        Console.WriteLine("perimeter:"+2*(width+height));
        
    }
}