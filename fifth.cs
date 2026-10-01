using System;

class Program
{
    public static void Main(string[] args)
    {
        Console.Write("enter the marks:");
        string[] marks=Console.ReadLine().Split();
        int a=int.Parse(marks[0]);
        int b=int.Parse(marks[1]);
        int c=int.Parse(marks[2]);
        Console.WriteLine("Average:"+(a+b+c)/3);
    }
}