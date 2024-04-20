using Microsoft.Maui.Controls;
using System;

namespace ToDoList
{
    public partial class NewTaskPage : ContentPage
    {
        TodoItemDatabase database;

        public NewTaskPage()
        {
            InitializeComponent();
            database = new TodoItemDatabase();
        }

        private async void AddTaskButton_Clicked(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(TaskEntry.Text))
            {
                TodoItem newItem = new TodoItem()
                {
                    Name = TaskEntry.Text,
                    Done = false  
                };

                await database.SaveItemAsync(newItem);
                TaskEntry.Text = "";  

                await Shell.Current.GoToAsync("..");
            }
        }
    }
}
