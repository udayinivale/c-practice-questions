// Grade calculator
// Read a mark out of 100 and print the grade: 90 and above is A, 75 to 89 is B, 60 to 74 is C, 40 to
// 59 is D, below 40 is Fail. Also reject marks outside 0 to 100.
int marks=int.Parse(Console.ReadLine()!);
if (marks > 100)
{
    Console.WriteLine("Enter Valid Marks");
}
else if(marks>=90 && marks < 90)
{
    Console.WriteLine($"The grade is A");
}
else if(marks>=75 && marks <= 89)
{
    Console.WriteLine($"The grade is B");
}
else if(marks>=60 && marks < 74)
{
    Console.WriteLine($"The grade is C");
}
else if(marks>=40 && marks < 59)
{
    Console.WriteLine($"The grade is D");
}
else
{
    Console.WriteLine("Failed");
}
 