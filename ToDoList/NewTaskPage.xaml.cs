using Microsoft.Maui.Controls;

namespace ToDoList
{
    public partial class NewTaskPage : ContentPage
    {
        public NewTaskPage()
        {
            InitializeComponent();
        }

        private void AddTaskButton_Clicked(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(TaskEntry.Text))
            {
                TaskService.Current.Tasks.Add(TaskEntry.Text);
                TaskEntry.Text = "";  // Clear the entry field
            }
        }
    }
}
