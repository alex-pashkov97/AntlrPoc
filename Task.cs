using System;

public class Task
{
    public int Id { get; set; }

    public double ValueToCompare { get; set; }

    public string Description { get; set; }

    public Task(int id, string description, double valueToCompare)
    {
        Id = id;
        Description = description;
        ValueToCompare = valueToCompare;
    }
}

public class TaskProcessor
{
    public void PushToOrder(Task task)
    {
        Console.WriteLine($"Pushing Task {task.Id} with description '{task.Description}' to order.");
        // Add logic here for pushing the task to an order system.
    }

    public void CallExternal(Task task)
    {
        Console.WriteLine($"Calling external service for Task {task.Id} with description '{task.Description}'.");
        // Add logic here for calling an external service.
    }
}
