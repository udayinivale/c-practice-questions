int num = int.Parse(Console.ReadLine()!);
 
int reversed = 0;
 
while (num != 0)
{
    int digits = num % 10;
    reversed = reversed * 10 + digits;
    num = num / 10;
}
 
Console.WriteLine($"Reversed number: {reversed}");