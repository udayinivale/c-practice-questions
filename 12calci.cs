using System;
class Caluclator
{
    public static void Main(string[] args)
    {   Console.Write("Enter first number:");
        int a=int.Parse(Console.ReadLine());
        Console.Write("Enter operator:");
        string output=Console.ReadLine();
        Console.Write("Enter second number:");
        int b=int.Parse(Console.ReadLine());
 
 
        switch (output){
            case "+":
                Console.WriteLine(a+b);
                break;
            case "-":
                Console.WriteLine(a-b);
                break;
            case "*":
                Console.WriteLine(a*b);
                break;
            case "/":
                if (b == 0)
                {
                    Console.WriteLine("Cannot divide by zero");
                }
                else
                {
                    Console.WriteLine(a/b);
                }
               
                break;
           
 
        }
    }
}
 