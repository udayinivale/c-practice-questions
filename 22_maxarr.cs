using System;

public class Maximum
{
    public static void Main(string[] args)
    {
        int[] numbers = { 10, 25, 5, 40, 15 };

        int max = numbers[0];

        for (int i = 1; i < numbers.Length; i++)
        {
            if (numbers[i] > max)
            {
                max = numbers[i];
            }
        }

        Console.WriteLine("Maximum value: " + max);
    }
}