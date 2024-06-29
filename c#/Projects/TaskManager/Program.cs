// https://github.com/Kalutu/csharp-for-everybody/tree/main/Task Manager

namespace Projects
{

    // Dependency Injection using constructor
    class TaskHelper {
        private readonly ITaskManager _taskManager;
        
        public TaskHelper(ITaskManager taskManager) {
            _taskManager = taskManager;
        }

        public void Menu() {
            try
            {
                _taskManager.ChooseMenuItem();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

    }

    class Program {
        static void Main () {
            // Instantiating TaskHelper class and passing object for TaskManager class as param
            TaskHelper task = new (new TaskManager());
            task.Menu();
        }
    }

 
}