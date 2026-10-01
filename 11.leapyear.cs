using System;
class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Enter year:");
        int year=int.Parse(Console.ReadLine());
        if ((year%4==0 & year%100!=0) || (year % 400 == 0))
        {
            Console.WriteLine($"{year} is a Leap year");
        }
        else
        {
            Console.WriteLine($"{year} is Not a Leap Year");
        }
    }
}