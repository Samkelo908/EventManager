using System;

class Program
{
    static void Main(string[] args)
    {
        EventManager manager = new EventManager();
        bool running = true;

        while (running)
        {
            Console.WriteLine("\nEvent Attendee Manager");
            Console.WriteLine("1. Add Attendee");
            Console.WriteLine("2. Remove Attendee");
            Console.WriteLine("3. Display All Attendees");
            Console.WriteLine("4. Exit");
            Console.Write("Please enter your choice: ");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Console.Write("Enter attendee name: ");
                    string nameToAdd = Console.ReadLine();
                    if (!string.IsNullOrWhiteSpace(nameToAdd))
                    {
                        manager.AddAttendee(nameToAdd);
                    }
                    else
                    {
                        Console.WriteLine("Invalid name. Please try again.");
                    }
                    break;

                case "2":
                    Console.Write("Enter attendee name to remove: ");
                    string nameToRemove = Console.ReadLine();
                    if (!string.IsNullOrWhiteSpace(nameToRemove))
                    {
                        manager.RemoveAttendee(nameToRemove);
                    }
                    else
                    {
                        Console.WriteLine("Invalid name. Please try again.");
                    }
                    break;

                case "3":
                    manager.DisplayAllAttendees();
                    break;

                case "4":
                    Console.WriteLine("Thank you for using Event Attendee Manager. Goodbye!");
                    running = false;
                    break;

                default:
                    Console.WriteLine("Invalid choice. Please enter a number between 1 and 4.");
                    break;
            }
        }
    }
}