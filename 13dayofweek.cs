using System;
class Week
{
    public static void Main(string[] args)
    {
        Console.Write("Enter day :");
        int nums=int.Parse(Console.ReadLine());
        switch (nums)
        {
            case 1:
                Console.WriteLine("Monday");
                break;
            case 2:
                Console.WriteLine("Tuesday");
                break;
            case 3:
                Console.WriteLine("wednesday");
                break;
            case 4:
                Console.WriteLine("thurday");
                break;
            case 5:
                Console.WriteLine("friday");
                break;
            case 6:
                Console.WriteLine("saturday");
                break;
            case 7:
                Console.WriteLine("sunday");
                break;
            default:
                Console.WriteLine("Invalid number");
                break;
        }
 
    }
}