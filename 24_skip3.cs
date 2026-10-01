
using System;
class Program
{
    public static void Main(string[] args)
    {
        for (int i=0;i<=20;i++)
        {
            if (i % 3 == 0)
            {
                continue;
            }
            Console.Write(i + " ");
        }

    }
}