using System;
using System.Collections.Generic;

public class EventManager
{
    private HashSet<string> attendees;

    public EventManager()
    {
        attendees = new HashSet<string>();
    }

    public void AddAttendee(string name)
    {
        if (attendees.Add(name))
        {
            Console.WriteLine($"\"{name}\" has been registered successfully.");
        }
        else
        {
            Console.WriteLine($"\"{name}\" is already registered.");
        }
    }

    public void RemoveAttendee(string name)
    {
        if (attendees.Remove(name))
        {
            Console.WriteLine($"\"{name}\" has been removed.");
        }
        else
        {
            Console.WriteLine($"\"{name}\" was not found in the registration list.");
        }
    }

    public void DisplayAllAttendees()
    {
        Console.WriteLine("--- Registered Attendees ---");

        if (attendees.Count == 0)
        {
            Console.WriteLine("No one is registered yet.");
        }
        else
        {
            foreach (string attendee in attendees)
            {
                Console.WriteLine(attendee);
            }
        }
    }
}