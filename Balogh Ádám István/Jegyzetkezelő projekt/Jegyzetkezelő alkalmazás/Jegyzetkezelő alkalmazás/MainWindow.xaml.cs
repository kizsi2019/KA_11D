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
            customers.Add(new Customer());
        }

        private void SaveChanges_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Változtatások sikeresek elmentve!");
        }

        private void EditCustomer_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void DeleteCustomer_Click(object sender, RoutedEventArgs e)
        {
            
            if (customerDataGrid.SelectedItem != null)
            {
              
                customers.Remove((Customer)customerDataGrid.SelectedItem);
            }
            else
            {
                MessageBox.Show("Nincs kiválasztott ügyfél a törléshez.");
            }
        }
    }
}
