using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Globalization;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Input;
using System.Windows.Media;

namespace TodoListApp
{
    public partial class MainWindow : Window, INotifyPropertyChanged
    {
        public ObservableCollection<TodoItem> TodoItems { get; set; }
        public string NewTodoText { get; set; }
        public bool FilterCompleted { get; set; }

        public ICommand AddTodoCommand { get; private set; }
        public ICommand DeleteTodoCommand { get; private set; }
        public ICommand MarkTodoCompleteCommand { get; private set; }
        public ICommand FilterTodoListCommand { get; private set; }

        public event PropertyChangedEventHandler PropertyChanged;

        public MainWindow()
        {
            InitializeComponent();

            TodoItems = new ObservableCollection<TodoItem>();
            NewTodoText = "";
            FilterCompleted = false;

            AddTodoCommand = new RelayCommand(AddTodo);
            DeleteTodoCommand = new RelayCommand(DeleteTodo);
            MarkTodoCompleteCommand = new RelayCommand(MarkTodoComplete);
            FilterTodoListCommand = new RelayCommand(FilterTodoList);
        }

        private void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public void AddTodo()
        {
            if (String.IsNullOrEmpty(NewTodoText))
            {
                return;
            }

            TodoItems.Add(new TodoItem { Text = NewTodoText, IsCompleted = false });
            NewTodoText = "";
        }

        public void DeleteTodo(object todoItem)
        {
            TodoItems.Remove(todoItem as TodoItem);
        }

        public void MarkTodoComplete(object todoItem)
        {
            var item = todoItem as TodoItem;
            if (item != null)
            {
                item.IsCompleted = !item.IsCompleted;
            }
        }

        public void FilterTodoList()
        {
            FilterCompleted = !FilterCompleted;
        }
    }

    public class TodoItem : INotifyPropertyChanged
    {
        public string Text { get; set; }
        public bool IsCompleted { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }

    // RelayCommand class (optional, but improves decoupling)
    public class RelayCommand : ICommand
    {
        private readonly Action execute;
        private readonly Func<bool> canExecute;

        public RelayCommand(Action execute, Func<bool> canExecute = null)
        {
            this.execute = execute;
            this.canExecute = canExecute;
        }

        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            return canExecute == null ? true : canExecute();
        }

        public void Execute(object parameter)
        {
            execute();
        }
    }
}
