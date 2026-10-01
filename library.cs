using System;
using System.Collections.Generic;

class Book
{
    public string Title;
    public string Author;

    public Book(string title, string author)
    {
        Title = title;
        Author = author;
    }
}

class Program
{
    static void Main()
    {
        List<Book> books = new List<Book>();

        books.Add(new Book("The Pragmatic Programmer", "Hunt"));
        books.Add(new Book("C# in Depth", "Skeet"));
        books.Add(new Book("Clean Code", "Martin"));
        books.Add(new Book("C# 12 Pocket Reference", "Skeet"));

        Dictionary<string, int> authorCount = new Dictionary<string, int>();

        foreach (Book book in books)
        {
            if (authorCount.ContainsKey(book.Author))
            {
                authorCount[book.Author]++;
            }
            else
            {
                authorCount.Add(book.Author, 1);
            }
        }

        foreach (Book book in books)
        {
            Console.WriteLine(book.Title + " by " + book.Author);
        }

        string mostPublished = "";
        int highest = 0;

        foreach (KeyValuePair<string, int> item in authorCount)
        {
            if (item.Value > highest)
            {
                highest = item.Value;
                mostPublished = item.Key;
            }
        }

        Console.WriteLine("Most published: " + mostPublished +
                          " (" + highest + " books)");
    }
}