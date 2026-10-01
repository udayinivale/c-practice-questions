using System;

public class Student
{
    private int _marks;

    public int Marks
    {
        get
        {
            return _marks;
        }
        set
        {
            if (value >= 0 && value <= 100)
            {
                _marks = value;
            }
            else
            {
                Console.WriteLine("Invalid marks");
            }
        }
    }

    public void Display()
    {
        Console.WriteLine("Marks: " + _marks);
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        Student s = new Student();

        Console.Write("enter marks:");
        int marks = int.Parse(Console.ReadLine());

        s.Marks = marks;

        if (marks >= 0 && marks <= 100)
        {
            s.Display();
        }
    }
}

