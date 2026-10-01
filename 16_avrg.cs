using System;

int n = int.Parse(Console.ReadLine()!);
 
int sum = 0;
 
for (int i = 1; i <= n; i++)
{
    sum += i;
}
 
double avrg = (double)sum / n;
 
Console.WriteLine($"Sum: {sum}");
Console.WriteLine($"Average: {avrg}");
 