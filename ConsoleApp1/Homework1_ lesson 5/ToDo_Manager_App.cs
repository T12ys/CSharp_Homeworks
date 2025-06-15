namespace ToDoApp
{
    
    public enum TaskStatus
    {
        NotStarted,
        InProgress,
        Completed,
        Deferred
    }
    
    
    
    public class TaskItem
    {
        
        public string Title;
        public string Description;
        public TaskStatus Status;

        public TaskItem(string title, string description)
        {
            
            Title = title;
            Description = description;
            Status = TaskStatus.NotStarted;
            
        }

        public void UpdateStatus(TaskStatus newStatus)
        {
            Status = newStatus;
        }

        public string GetDetails()
        {
            return "Title: " + Title + "\nDescription:" + Description + "\nStatus: " + Status + "\n";
        }
        
    }

    
    
   
    public class TaskManager
    {
        
        private List<TaskItem> tasks = new ();

        public void AddTask(TaskItem task)
        {
            
            tasks.Add(task);
            Console.WriteLine("Task added successfully.");
            
        }

        public void ShowAllTasks()
        {
            if (tasks.Count == 0)
            {
                
                Console.WriteLine("No tasks available.");
                return;
                
            }

            Console.WriteLine("\nAll Tasks:");
            for (int i = 0; i < tasks.Count; i++)
            {
                
                Console.WriteLine("Task #" + (i + 1));
                Console.WriteLine(tasks[i].GetDetails());
                
            }
            
        }

        public void ShowTasksByStatus(TaskStatus status)
        {
            
            Console.WriteLine("\nTasks with status: " + status);
            bool found = false;

            for (int i = 0; i < tasks.Count; i++)
            {
                
                if (tasks[i].Status == status)
                {
                    
                    Console.WriteLine("Task #" + (i + 1));
                    Console.WriteLine(tasks[i].GetDetails());
                    found = true;
                    
                }
            }

            if (!found)
            {
                Console.WriteLine("No tasks found with this status.");
            }
        }

        
        
        public void ChangeTaskStatus(int taskNumber, TaskStatus newStatus)
        {
            
            if (taskNumber < 1 || taskNumber > tasks.Count)
            {
                Console.WriteLine("Invalid task number.");
                return;
            }

            tasks[taskNumber - 1].UpdateStatus(newStatus);
            Console.WriteLine("Task status updated.");
        }
    }

    class Program
    {
        static void Main()
        {
            TaskManager manager = new TaskManager();
            string input;

            while (true)
            {
                Console.WriteLine("\n==== To-Do List ====");
                Console.WriteLine("1. Add Task");
                Console.WriteLine("2. Show All Tasks");
                Console.WriteLine("3. Show Tasks by Status");
                Console.WriteLine("4. Change Task Status");
                Console.WriteLine("0. Exit");
                Console.Write("Choose option: "); 
                
                input = Console.ReadLine();

                
                if (input == "1")
                {
                    
                    Console.Write("Enter task title: ");
                    string title = Console.ReadLine();

                    Console.Write("Enter task description: ");
                    string description = Console.ReadLine();

                    TaskItem newTask = new TaskItem(title, description);
                    manager.AddTask(newTask);
                    
                }
                else if (input == "2")
                {
                    manager.ShowAllTasks();
                }
                else if (input == "3")
                {
                    
                    TaskStatus status = ReadStatusFromUser();
                    manager.ShowTasksByStatus(status);
                    
                }
                else if (input == "4")
                {
                    
                    manager.ShowAllTasks();

                    Console.Write("Enter task number to change status: ");
                    string numInput = Console.ReadLine();
                    int taskNumber;

                    if (int.TryParse(numInput, out taskNumber))
                    {
                        
                        TaskStatus newStatus = ReadStatusFromUser();
                        manager.ChangeTaskStatus(taskNumber, newStatus);
                        
                    }
                    else
                    {
                        Console.WriteLine("Invalid number.");
                    }
                    
                }
                else if (input == "0")
                {
                    
                    Console.WriteLine("Goodbye!");
                    break;
                    
                }
                else
                {
                    Console.WriteLine("Unknown option. Try again.");
                }
            }
        }
        
        

        static TaskStatus ReadStatusFromUser()
        {
            Console.WriteLine("Select status:");
            Console.WriteLine("0 - NotStarted");
            Console.WriteLine("1 - InProgress");
            Console.WriteLine("2 - Completed");
            Console.WriteLine("3 - Deferred");
            Console.Write("Enter number: ");
            
            string input = Console.ReadLine();
            int choice;

            if (int.TryParse(input, out choice)  && choice >= 0  && choice <= 3)
            {
                return (TaskStatus)choice;
            }

            Console.WriteLine("Invalid input, defaulting to NotStarted.");
            return TaskStatus.NotStarted;
        }
    }
}
