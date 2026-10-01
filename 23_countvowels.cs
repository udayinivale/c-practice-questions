using System;

public class Vowels
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter a word:");
        string name = Console.ReadLine();

        int count = 0;

        foreach (char ch in name)
        {
            if ("aeiouAEIOU".Contains(ch))
            {
                count++;
            }
        }

        Console.WriteLine("Number of vowels: " + count);
    }
}