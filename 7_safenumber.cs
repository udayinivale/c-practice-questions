using System;
class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("enter a number");
        string input=Console.ReadLine();
        if (int.TryParse(input,out int nums))
        {
            Console.WriteLine("valid");
        }
        else
        {
            Console.WriteLine("it is not a valid number");
        }
    }
}
