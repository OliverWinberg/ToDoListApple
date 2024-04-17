using System.Collections.ObjectModel;

namespace ToDoList
{
    public class TaskService
    {
        public static TaskService Current { get; } = new TaskService();

        public ObservableCollection<string> Tasks { get; } = new ObservableCollection<string>();
    }
}
