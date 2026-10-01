using System;
class Program
{
    public static void Main(string[] args)
    {
        int principal=50000;
        decimal rate=7.5m;
        int time=3;
        decimal total=((principal*rate*time)/100);
        Console.WriteLine("total:"+total);
    }
}