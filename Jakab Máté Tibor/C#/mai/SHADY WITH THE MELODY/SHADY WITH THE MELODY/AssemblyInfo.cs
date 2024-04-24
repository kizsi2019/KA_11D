using System.ComponentModel;

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
