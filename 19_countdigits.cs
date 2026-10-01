int numbers = int.Parse(Console.ReadLine()!);
 
int count = 0;
 
while (numbers != 0)
{
    numbers = numbers / 10;
    count++;
}
 
Console.WriteLine($"Number of digits: {count}");