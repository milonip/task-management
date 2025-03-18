# Task Management System

A console-based task management application built with .NET that helps users manage their tasks efficiently.

## Features

- Add new tasks with title and description
- View all tasks in the system
- View pending tasks
- Mark tasks as complete
- Tasks are automatically timestamped at creation
- Organized display of task information including ID, title, description, and status

## Project Structure

task-management/

├── Models/
│   └── TaskItem.cs
├── Services/
│   └── TaskService.cs
├── Program.cs
└── README.md

## Getting Started

### Prerequisites

- .NET 6.0 or later
- Any code editor (Visual Studio, VS Code, etc.)

### Running the Application

1. Clone the repository
```bash
git clone https://github.com/milonip/task-management.git
```

2. Navigate to the project directory
```bash
cd task-management
```

3. Run the application
```bash
dotnet run
```

## Usage
The application provides a simple console interface with the following options:

1. Add Task - Create a new task with title and description
2. View All Tasks - Display all tasks in the system
3. Mark Task as Complete - Mark a specific task as completed using its ID
4. View Pending Tasks - Show only incomplete tasks
5. Exit - Close the application

## Technical Details
- Built with C# and .NET
- Uses LINQ for data querying
- Implements service-based architecture
- Follows object-oriented programming principles

## Future Enhancements
- Data persistence using file storage or database
- Task categories and priority levels
- Due dates for tasks
- Task editing functionality
- Task deletion capability

## Contributing
Feel free to fork this project and submit pull requests for any improvements.

## Author
Miloni Patel
