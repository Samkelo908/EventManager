# Event Attendee Manager

A simple console application for managing event attendees with automatic duplicate prevention using C# and HashSet.

## Overview

This application helps event organizers keep track of registered attendees for a community event. The key feature is automatic prevention of duplicate registrations - each person can only register once.

## Features

- **Add Attendees**: Register new attendees by name
- **Remove Attendees**: Remove attendees from the registration list
- **View All Attendees**: Display a complete list of registered attendees
- **Duplicate Prevention**: Automatically prevents the same person from registering multiple times
- **User-Friendly Interface**: Simple menu-driven console interface

## Technologies Used

- **Language**: C#
- **Data Structure**: `HashSet<string>` for O(1) performance and automatic uniqueness
- **Framework**: .NET Console Application

## Project Structure

```
EventAttendeeManager/
├── EventManager.cs    # Core business logic for managing attendees
├── Program.cs         # Main program with user interface
└── README.md          # This file
```

## Getting Started

### Prerequisites

- .NET SDK (version 6.0 or higher recommended)
- A C# IDE or text editor (Visual Studio, VS Code, or Rider)

### Installation

1. Clone or download this repository
2. Open a terminal in the project directory
3. Run the following command to build the project:

```bash
dotnet build
```

### Running the Application

Execute the application using:

```bash
dotnet run
```

## Usage

When you run the application, you'll see a menu with the following options:

```
Event Attendee Manager
1. Add Attendee
2. Remove Attendee
3. Display All Attendees
4. Exit
Please enter your choice:
```

### Adding an Attendee

1. Select option `1`
2. Enter the attendee's name when prompted
3. You'll receive confirmation if the registration is successful
4. If the name already exists, you'll be notified

### Removing an Attendee

1. Select option `2`
2. Enter the name of the attendee to remove
3. You'll receive confirmation if the removal is successful
4. If the name is not found, you'll be notified

### Viewing All Attendees

1. Select option `3`
2. The application will display all registered attendees
3. If no one is registered, you'll see "No one is registered yet."

### Exiting the Application

Select option `4` to exit the program

## Example Session

```
Event Attendee Manager
1. Add Attendee
2. Remove Attendee
3. Display All Attendees
4. Exit
Please enter your choice: 1
Enter attendee name: John Smith
"John Smith" has been registered successfully.

Event Attendee Manager
1. Add Attendee
2. Remove Attendee
3. Display All Attendees
4. Exit
Please enter your choice: 1
Enter attendee name: John Smith
"John Smith" is already registered.

Event Attendee Manager
1. Add Attendee
2. Remove Attendee
3. Display All Attendees
4. Exit
Please enter your choice: 3
--- Registered Attendees ---
John Smith
```

## Code Explanation

### EventManager Class

The `EventManager` class encapsulates all attendee management logic:

- **Private Field**: `HashSet<string> attendees` stores unique attendee names
- **Constructor**: Initializes the empty HashSet
- **AddAttendee()**: Leverages HashSet's `Add()` method which returns false for duplicates
- **RemoveAttendee()**: Uses HashSet's `Remove()` method which returns false if not found
- **DisplayAllAttendees()**: Iterates through the HashSet to display all names

### Why HashSet?

The `HashSet<string>` data structure was chosen because:
- Automatically enforces uniqueness
- Provides O(1) average time complexity for add, remove, and lookup operations
- Simple API that makes the code clean and maintainable
- Perfect for scenarios where order doesn't matter but uniqueness does

## Future Enhancements

Potential improvements for this application:

- Add email validation for attendees
- Include attendee details (email, phone number)
- Save and load attendee data from a file
- Search functionality to find specific attendees
- Sort attendees alphabetically when displaying
- Add capacity limits for the event
- Export attendee list to CSV

## License

This project is available for educational purposes.

## Author

Created as a learning exercise for C# collections and console applications.
