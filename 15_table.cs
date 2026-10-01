using System;

public class Table{
    public static void Main(string[] args)
{   Console.WriteLine("Enter number:");
    int nums = int.Parse(Console.ReadLine());
    for (int i = 1; i <= 10; i++)
    {
 
    Console.WriteLine(nums+" * "+i+" = "+(i*nums));
    }
        Console.WriteLine();
    }
}