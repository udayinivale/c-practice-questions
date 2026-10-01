using System;


class Program
{
    static void Main()
    {
        bool[] seats = new bool[10];

        Dictionary<int, string> bookings =
            new Dictionary<int, string>();

        BookSeat(3, "Amit", seats, bookings);
        BookSeat(5, "Priya", seats, bookings);
        BookSeat(7, "Rahul", seats, bookings);

        BookSeat(5, "Anil", seats, bookings);

        CancelSeat(7, seats, bookings);

        Console.Write("Map: ");

        for (int i = 0; i < seats.Length; i++)
        {
            if (seats[i])
            {
                Console.Write("X ");
            }
            else
            {
                Console.Write(". ");
            }
        }

        int free = 0;

        for (int i = 0; i < seats.Length; i++)
        {
            if (!seats[i])
            {
                free++;
            }
        }

        Console.WriteLine();
        Console.WriteLine("Free seats: " + free);
    }

    static void BookSeat(
        int seatNumber,
        string name,
        bool[] seats,
        Dictionary<int, string> bookings)
    {
        int index = seatNumber - 1;

        if (seats[index])
        {
            Console.WriteLine("Seat " + seatNumber + " is already taken");
        }
        else
        {
            seats[index] = true;
            bookings.Add(seatNumber, name);

            Console.WriteLine("Seat " + seatNumber +
                              " booked for " + name);
        }
    }

    static void CancelSeat(
        int seatNumber,
        bool[] seats,
        Dictionary<int, string> bookings)
    {
        int index = seatNumber - 1;

        if (seats[index])
        {
            seats[index] = false;
            bookings.Remove(seatNumber);

            Console.WriteLine("Seat " + seatNumber + " cancelled");
        }
    }
}