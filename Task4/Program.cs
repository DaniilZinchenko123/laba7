namespace Task4
{
    public class Program
    {
        static void Main()
        {
            TaskScheduler<string, int> scheduler = new TaskScheduler<string, int>(ExecuteTask);
            scheduler.AddTask("Task 1", 3);
            scheduler.AddTask("Task 2", 1);
            scheduler.AddTask("Task 3", 2);

            Console.WriteLine("Task Queue:");
            scheduler.PrintTaskQueue();

            scheduler.ExecuteNext();

            Console.WriteLine("\nUpdated Task Queue:");
            scheduler.PrintTaskQueue();
        }

        static void ExecuteTask(string task)
        {
            Console.WriteLine($"Executing task: {task}");
        }
    }
}