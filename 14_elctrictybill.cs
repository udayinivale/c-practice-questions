using System;
class ElectricityBill
{
    static void Main()
    {
        Console.Write("Enter units consumed: ");
        int units = int.Parse(Console.ReadLine()!);
 
        int billval;
 
        if (units <= 100)
        {
            billval = units * 5;
        }
        else if (units <= 200)
        {
            billval = (100 * 5) + (units - 100) * 7;
        }
        else
        {
            billval = (100 * 5) + (100 * 7) + (units - 200) * 10;
        }
        Console.WriteLine("Total Bill: " + billval);
    }
}