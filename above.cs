using System;

class Program
{
    static void Main()
    {
        int[] marks = { 70, 80, 90, 80, 60 };

        int total = 0;

        for (int i = 0; i < marks.Length; i++)
        {
            total += marks[i];
        }

        double average = (double)total / marks.Length;

        int above = 0;
        int below = 0;
        int equal = 0;

        for (int i = 0; i < marks.Length; i++)
        {
            if (marks[i] > average)
            {
                above++;
            }
            else if (marks[i] < average)
            {
                below++;
            }
            else
            {
                equal++;
            }
        }

        Console.WriteLine("Average: " + average.ToString("F2"));
        Console.WriteLine("Above average: " + above);
        Console.WriteLine("Below average: " + below);
        Console.WriteLine("Equal to average: " + equal);
    }
}