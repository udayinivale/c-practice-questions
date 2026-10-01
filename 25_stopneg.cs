using System;

class Program
{
    public static void Main(string[] args)
    {
        int[] number={10, 25, 8, -4, 60};
        int sum=0;
        foreach(int num in number)
        {
            if(num<0)
            
            {
                break;
            }
            sum+=num;
        }
        Console.WriteLine("sum:"+sum);
    }
}