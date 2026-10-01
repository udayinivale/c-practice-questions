int choice;
 
do
{
    Console.WriteLine("1. Add");
    Console.WriteLine("2. Subtract");
    Console.WriteLine("3. Multiply");
    Console.WriteLine("4. Exit");
 
    Console.Write("Enter your choice: ");
    choice = int.Parse(Console.ReadLine()!);
 
    switch (choice)
    {
        case 1:
            Console.WriteLine("You chose to Add");
            break;
 
        case 2:
            Console.WriteLine("You chose to Subtract");
            break;
 
        case 3:
            Console.WriteLine("You chose to Multiply");
            break;
 
        case 4:
            Console.WriteLine("Exiting...");
            break;
 
        default:
            Console.WriteLine("Invalid choice");
            break;
    }
 
} while (choice != 4);