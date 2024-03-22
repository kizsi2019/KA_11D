// MainWindow.xaml.cs

using System.Collections.ObjectModel;
using System.Windows;

namespace CustomerManagementApp
{
    public partial class MainWindow : Window
    {
        private ObservableCollection<Customer> customers;

        public MainWindow()
        {
            InitializeComponent();
            customers = new ObservableCollection<Customer>();
            customerDataGrid.ItemsSource = customers;
        }

        private void AddCustomer_Click(object sender, RoutedEventArgs e)
        {
            // Az új ügyfél hozzáadása
            customers.Add(new Customer());
        }

        private void SaveChanges_Click(object sender, RoutedEventArgs e)
        {
            // Változtatások mentése
            // Itt lehetne az adatbázisba menteni az új vagy módosított ügyfeleket
            MessageBox.Show("Changes saved successfully!");
        }
    }
}
