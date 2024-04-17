using System;
using Microsoft.Maui.Controls;

namespace ToDoList
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
            TasksListView.ItemsSource = TaskService.Current.Tasks;
        }

        private async void OnCounterClicked(object sender, EventArgs e)
        {
            count++;
            if (count == 10)
            {
                await DisplayAlert("Alert", "Du har frøkenet rundt 10 gange idag", "OK");
                count = 0;
                CounterBtn.Text = "Klik her hvis du frøkener rundt";
            }
            else
            {
                CounterBtn.Text = $"Du har frøkenet rundt {count} gange i dag";
            }
            SemanticScreenReader.Announce(CounterBtn.Text);
        }

        private async void AddNewTaskButton_Clicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync(nameof(NewTaskPage));
        }

        private void SettingsButton_Clicked(object sender, EventArgs e)
        {
            DisplayAlert("Settings", "Settings button clicked", "OK");
        }
    }
}
