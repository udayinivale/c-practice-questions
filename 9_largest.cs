using System;
class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter 3 numbers:");
        string[] nums=Console.ReadLine().Split();
        int a=int.Parse(nums[0]);
        int b=int.Parse(nums[1]);
        int c=int.Parse(nums[2]);
        if ((a>b) &(b > c)){
            Console.WriteLine("Largest:"+a);
        }
        else if((b>c)&(b>a)){
            Console.WriteLine("Largest:"+b);    
        }
        else
        {
            Console.WriteLine("Largest:"+c);
        }
 
 
    }
}