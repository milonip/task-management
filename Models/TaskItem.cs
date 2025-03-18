namespace TaskManager.Models;

public class TaskItem
{
    public int Id { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public bool IsCompleted { get; set; }
    public DateTime CreatedDate { get; set; }

    public TaskItem(int id, string title, string description)
    {
        Id = id;
        Title = title;
        Description = description;
        IsCompleted = false;
        CreatedDate = DateTime.Now;
    }
}