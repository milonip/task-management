using TaskManager.Models;
using TaskManager.Services;

namespace TaskManager;

class Program
{
    static void Main(string[] args)
    {
        var taskService = new TaskService();
        bool running = true;

        while (running)
        {
            Console.WriteLine("\n=== Task Management System ===");
            Console.WriteLine("1. Add Task");
            Console.WriteLine("2. View All Tasks");
            Console.WriteLine("3. Mark Task as Complete");
            Console.WriteLine("4. View Pending Tasks");
            Console.WriteLine("5. Exit");
            Console.Write("\nSelect an option: ");

            string? choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    AddNewTask(taskService);
                    break;
                case "2":
                    ViewAllTasks(taskService);
                    break;
                case "3":
                    MarkTaskComplete(taskService);
                    break;
                case "4":
                    ViewPendingTasks(taskService);
                    break;
                case "5":
                    running = false;
                    break;
                default:
                    Console.WriteLine("Invalid option. Please try again.");
                    break;
            }
        }
    }

    static void AddNewTask(TaskService taskService)
    {
        Console.Write("Enter task title: ");
        string? title = Console.ReadLine();
        Console.Write("Enter task description: ");
        string? description = Console.ReadLine();

        if (!string.IsNullOrWhiteSpace(title))
        {
            taskService.AddTask(title, description ?? "");
            Console.WriteLine("Task added successfully!");
        }
        else
        {
            Console.WriteLine("Task title cannot be empty!");
        }
    }

    static void ViewAllTasks(TaskService taskService)
    {
        var tasks = taskService.GetAllTasks();
        DisplayTasks(tasks);
    }

    static void ViewPendingTasks(TaskService taskService)
    {
        var tasks = taskService.GetPendingTasks();
        DisplayTasks(tasks);
    }

    static void DisplayTasks(IEnumerable<TaskItem> tasks)
    {
        if (!tasks.Any())
        {
            Console.WriteLine("No tasks found.");
            return;
        }

        foreach (var task in tasks)
        {
            Console.WriteLine($"\nID: {task.Id}");
            Console.WriteLine($"Title: {task.Title}");
            Console.WriteLine($"Description: {task.Description}");
            Console.WriteLine($"Status: {(task.IsCompleted ? "Completed" : "Pending")}");
            Console.WriteLine($"Created: {task.CreatedDate}");
        }
    }

    static void MarkTaskComplete(TaskService taskService)
    {
        Console.Write("Enter task ID to mark as complete: ");
        if (int.TryParse(Console.ReadLine(), out int id))
        {
            bool success = taskService.MarkTaskAsComplete(id);
            Console.WriteLine(success ? "Task marked as complete!" : "Task not found!");
        }
        else
        {
            Console.WriteLine("Invalid ID format!");
        }
    }
}
