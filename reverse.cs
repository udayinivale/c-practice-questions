using System;

class Program
{
    static void Main()
    {
        int[] arr = { 1, 2, 3, 4, 5 };

        Console.Write("Before: ");

        for (int i = 0; i < arr.Length; i++)
        {
            Console.Write(arr[i] + " ");
        }

        for (int i = 0; i < arr.Length / 2; i++)
        {
            int temp = arr[i];
            arr[i] = arr[arr.Length - 1 - i];
            arr[arr.Length - 1 - i] = temp;
        }

        Console.WriteLine();

        Console.Write("After: ");

        for (int i = 0; i < arr.Length; i++)
        {
            Console.Write(arr[i] + " ");
        }
    }
}