namespace TaskManager.Services;

using TaskManager.Models;

public class TaskService
{
    private List<TaskItem> _tasks;
    private int _currentId;

    public TaskService()
    {
        _tasks = new List<TaskItem>();
        _currentId = 1;
    }

    public void AddTask(string title, string description)
    {
        var task = new TaskItem(_currentId++, title, description);
        _tasks.Add(task);
    }

    public IEnumerable<TaskItem> GetAllTasks()
    {
        return _tasks.OrderBy(t => t.CreatedDate);
    }

    public IEnumerable<TaskItem> GetPendingTasks()
    {
        return _tasks.Where(t => !t.IsCompleted).OrderBy(t => t.CreatedDate);
    }

    public bool MarkTaskAsComplete(int id)
    {
        var task = _tasks.FirstOrDefault(t => t.Id == id);
        if (task != null)
        {
            task.IsCompleted = true;
            return true;
        }
        return false;
    }
}