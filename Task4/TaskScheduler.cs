namespace Task4
{
    public class TaskScheduler<TTask, TPriority>
    {
        public delegate void TaskExecution(TTask task);

        private SortedDictionary<TPriority, Queue<TTask>> taskQueue = new SortedDictionary<TPriority, Queue<TTask>>();
        private TaskExecution taskExecutionDelegate;

        public TaskScheduler(TaskExecution taskExecutionDelegate)
        {
            this.taskExecutionDelegate = taskExecutionDelegate;
        }

        public void AddTask(TTask task, TPriority priority)
        {
            if (!taskQueue.ContainsKey(priority))
            {
                taskQueue[priority] = new Queue<TTask>();
            }

            taskQueue[priority].Enqueue(task);
        }

        public void ExecuteNext()
        {
            if (taskQueue.Count > 0)
            {
                var highestPriority = taskQueue.Keys.Max();
                var taskToExecute = taskQueue[highestPriority].Dequeue();
                taskExecutionDelegate(taskToExecute);

                if (taskQueue[highestPriority].Count == 0)
                {
                    taskQueue.Remove(highestPriority);
                }
            }
            else
            {
                Console.WriteLine("No tasks to execute.");
            }
        }

        public void PrintTaskQueue()
        {
            foreach (var priority in taskQueue.Keys)
            {
                Console.WriteLine($"Priority {priority}:");

                foreach (var task in taskQueue[priority])
                {
                    Console.WriteLine($"- {task}");
                }
            }
        }
    }
}