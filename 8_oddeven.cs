using System;
class Program
{
    public static void Main(string[] args)
    {

        Console.WriteLine("Enter number:");
        int number = int.Parse(Console.ReadLine());
        if (number % 2 == 0)
        {
            Console.WriteLine($"{number} is Even");
       
        }
        else
        {
            Console.WriteLine($"{number} is Odd");
        }
    }
}