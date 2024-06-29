using System.Globalization;

namespace Projects
{
    public class ToDoList {
        public long? TaskNumber { get; set; }
        public string? TaskName { get; set; }
        public string? Description { get; set; }
        public DateOnly? ToDoDate { get; set; }
        public bool? IsCompleted { get; set; } = false;
        public DateTime? UpdatedOn { get; set; }
    }

    public delegate void GetUserInput(string[] input);
    public delegate void GetTaskNumber(ToDoList input);


    interface ITaskManager
    {
        void ChooseMenuItem();
        void ViewAllTasks();
        ToDoList GetTaskByTaskNumber(long taskNumber);
        void DisplayTasks(ToDoList task);
        void GenericGetUserInput (GetUserInput UserInput, string action);
        void GenericGetTaskNumber (GetTaskNumber TaskNumber, string action);

    }

    public class TaskManager: ITaskManager {
        static readonly List<ToDoList>? tasks = new();

        public void ChooseMenuItem () {
            try
            {
                // Ends only on exit
                while (true)
                {
                    Console.WriteLine("\n1. View Task\n2. Add Task\n3. Update Task\n4. Delete Task\n5. Mark as Completed\n6. Exit");
                    long option = Convert.ToInt64(Console.ReadLine());
                    switch (option)
                    {
                        case 1:
                            ViewAllTasks();
                            break;
                        case 2:
                            // Passing add user input function to generic function
                            // GetAddUserInput has same definition as delegate function GetUserInput
                            GenericGetUserInput(GetAddUserInput, "add");
                            break;
                        case 3:
                            GenericGetUserInput(GetUpdateUserInput, "update");
                            break;
                        case 4:
                            GenericGetTaskNumber (DeleteTask, "delete");
                            break;
                        case 5:
                            GenericGetTaskNumber (MarkTaskAsCompleted, "complete");
                            break;
                        case 6:
                            Console.WriteLine("Exiting...");
                            return;
                        default:
                            Console.WriteLine("Invalid option");
                            break;
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void ViewAllTasks() {
            if (tasks == null || tasks.Count == 0) {
                Console.WriteLine("\nNo tasks present\n");
                return;
            }

            foreach (ToDoList item in tasks)
            {
                DisplayTasks(item);
            }
            
        }

        public void DisplayTasks(ToDoList item) {
            Console.WriteLine($"Task: {item.TaskNumber} Task Name: {item.TaskName} Description: {item.Description} Date: {item.ToDoDate} Completed: {item.IsCompleted} Updated On: {item.UpdatedOn}");
        }

        public ToDoList GetTaskByTaskNumber(long taskNumber) {
            try
            {
                var item = tasks?.FirstOrDefault(x => x.TaskNumber == taskNumber);
                if (item == null) {
                    throw new Exception ("Task not found");
                }
                else {
                    return item;
                }
            }
            catch (System.Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        // Generic method for delegate for adding and updating tasks to list
        public void GenericGetUserInput (GetUserInput UserInput, string action) {
            try
            {
                ToDoList toDo = new ();
                string[] input = [];
                Console.WriteLine("\nEnter the to-do item in below form:");

                if (action.Equals("add", StringComparison.CurrentCultureIgnoreCase)) {
                    Console.WriteLine(@"TaskNo <\> TaskName <\> Description <\> TaskDate(mm/dd/yyyy)");
                    
                }
                else if (action.Equals("update", StringComparison.CurrentCultureIgnoreCase)) {
                    Console.WriteLine(@"TaskNo <\> Description <\> TaskDate(mm/dd/yyyy)");
                }

                Console.WriteLine();
                // Read user input in one line
                string? line = Console.ReadLine();
                if (!string.IsNullOrEmpty(line)) {
                    // split the input on space
                    input = line.Split("\\");
                    // call delegate methods (add, update)
                    UserInput(input);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);;
            }
        }

        public void GenericGetTaskNumber (GetTaskNumber TaskNumber, string action) {
            try
            {
                Console.WriteLine("Enter task number: ");
                long taskNo = Convert.ToInt64(Console.ReadLine());
                var task = GetTaskByTaskNumber(taskNo);

                if (action.Equals("delete", StringComparison.CurrentCultureIgnoreCase)) {
                    TaskNumber(task);
                    
                }
                else if (action.Equals("complete", StringComparison.CurrentCultureIgnoreCase)) {
                    TaskNumber(task);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);;
            }
        }

        public void GetAddUserInput (string[] individualInput) {
            try
            {
                ToDoList toDo = new();
                if (individualInput.Length == 4) {
                    toDo.TaskNumber = Convert.ToInt64(individualInput[0]);
                    toDo.TaskName = individualInput[1];
                    toDo.Description = individualInput[2];
                    toDo.ToDoDate = FormatDateTime.ConvertToDateTime(individualInput[3]);
                    toDo.UpdatedOn = DateTime.Now;
                    tasks?.Add(toDo);
                } else {
                    throw new Exception ("Invalid input data for add");
                }
            }
            catch (System.Exception ex)
            {
                throw new Exception (ex.Message);
            }
            
        }

        public void GetUpdateUserInput (string[] individualInput) {
            try
            {
                if (individualInput.Length == 3) {
                    long taskNumber = Convert.ToInt64(individualInput[0]);
                    // Check whether the given task exists in list
                    var selectiveTask = GetTaskByTaskNumber(taskNumber);

                    selectiveTask.Description = individualInput[1];
                    selectiveTask.ToDoDate = FormatDateTime.ConvertToDateTime(individualInput[2]);
                    selectiveTask.UpdatedOn = DateTime.Now;
                    // display individual record
                    DisplayTasks(selectiveTask);
                }
                else {
                    throw new Exception ("Invalid input data for update");
                }
            }
            catch (System.Exception ex)
            {   
                throw new Exception(ex.Message);
            }
            
        }

        public void DeleteTask(ToDoList task) {
            tasks?.Remove(task);
            // view all the tasks
            ViewAllTasks();
        }

        public void MarkTaskAsCompleted(ToDoList task) {
            task.IsCompleted = true;
            // display individual record
            DisplayTasks(task);
        }
    }

    // extension method for converting string to datetime
    public static class FormatDateTime
    {
        public static DateOnly ConvertToDateTime(this string date)
        {
            return DateOnly.Parse(date, new CultureInfo("en-US"));
        }
    }

}