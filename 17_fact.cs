int n = int.Parse(Console.ReadLine()!);
 
long fact = 1;
 
for (int i = 1; i <= n; i++)
{
    fact = fact * i;
}
 
Console.WriteLine($"Factorial: {fact}");