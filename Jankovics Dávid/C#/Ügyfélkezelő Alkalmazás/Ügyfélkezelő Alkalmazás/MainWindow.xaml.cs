using Microsoft.Win32;
using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;

namespace CustomerManagementApp
{
    public class AddCustomerDialog : Window
    {
        public TextBox nameTextBox;
        public TextBox addressTextBox;
        public TextBox phoneTextBox;
        public TextBox emailTextBox;

        public Customer Customer { get; private set; }

        public AddCustomerDialog()
        {
            InitializeComponents();
        }

        private void InitializeComponents()
        {
            Title = "Add Customer";
            Width = 300;
            Height = 200;
            WindowStartupLocation = WindowStartupLocation.CenterOwner;

            //Grid létrehozása 
            Grid grid = new Grid();
            grid.Margin = new Thickness(10);

            ColumnDefinition column1 = new ColumnDefinition();
            ColumnDefinition column2 = new ColumnDefinition();
            grid.ColumnDefinitions.Add(column1);
            grid.ColumnDefinitions.Add(column2);

            RowDefinition row1 = new RowDefinition();
            RowDefinition row2 = new RowDefinition();
            RowDefinition row3 = new RowDefinition();
            RowDefinition row4 = new RowDefinition();
            RowDefinition row5 = new RowDefinition();
            grid.RowDefinitions.Add(row1);
            grid.RowDefinitions.Add(row2);
            grid.RowDefinitions.Add(row3);
            grid.RowDefinitions.Add(row4);
            grid.RowDefinitions.Add(row5);
            //Név Textbox
            Label nameLabel = new Label();
            nameLabel.Content = "Name:";
            Grid.SetRow(nameLabel, 0);
            Grid.SetColumn(nameLabel, 0);

            nameTextBox = new TextBox();
            Grid.SetRow(nameTextBox, 0);
            Grid.SetColumn(nameTextBox, 1);
            //Address Textbox
            Label addressLabel = new Label();
            addressLabel.Content = "Address:";
            Grid.SetRow(addressLabel, 1);
            Grid.SetColumn(addressLabel, 0);

            addressTextBox = new TextBox();
            Grid.SetRow(addressTextBox, 1);
            Grid.SetColumn(addressTextBox, 1);
            //Telefonszám textbox
            Label phoneLabel = new Label();
            phoneLabel.Content = "Phone:";
            Grid.SetRow(phoneLabel, 2);
            Grid.SetColumn(phoneLabel, 0);

            phoneTextBox = new TextBox();
            Grid.SetRow(phoneTextBox, 2);
            Grid.SetColumn(phoneTextBox, 1);
            //Email textbox

            Label emailLabel = new Label();
            emailLabel.Content = "Email:";
            Grid.SetRow(emailLabel, 3);
            Grid.SetColumn(emailLabel, 0);

            emailTextBox = new TextBox();
            Grid.SetRow(emailTextBox, 3);
            Grid.SetColumn(emailTextBox, 1);
            grid.Children.Add(emailLabel);
            grid.Children.Add(emailTextBox);
            //Mentés gomb
            Button saveButton = new Button();
            saveButton.Content = "Save";
            saveButton.Click += SaveButton_Click;
            Grid.SetRow(saveButton, 4);
            Grid.SetColumn(saveButton, 0);

            Button cancelButton = new Button();
            cancelButton.Content = "Cancel";
            cancelButton.Click += CancelButton_Click;
            Grid.SetRow(cancelButton, 4);
            Grid.SetColumn(cancelButton, 1);

            grid.Children.Add(nameLabel);
            grid.Children.Add(nameTextBox);
            grid.Children.Add(addressLabel);
            grid.Children.Add(addressTextBox);
            grid.Children.Add(phoneLabel);
            grid.Children.Add(phoneTextBox);
            grid.Children.Add(saveButton);
            grid.Children.Add(cancelButton);

            Content = grid;
        }

        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            // Ellenőrizzük, hogy minden mező kitöltve van-e
            if (string.IsNullOrWhiteSpace(nameTextBox.Text) ||
                string.IsNullOrWhiteSpace(addressTextBox.Text) ||
                string.IsNullOrWhiteSpace(phoneTextBox.Text) ||
                string.IsNullOrWhiteSpace(emailTextBox.Text))
            {
                MessageBox.Show("Please fill out all fields.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            // Ellenőrizze az e-mail cím formátumát
            if (!IsValidEmail(emailTextBox.Text))
            {
                MessageBox.Show("Please enter a valid email address.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            // Ha minden mező kitöltve van és az e-mail cím érvényes, akkor mentjük az ügyfelet
            Customer = new Customer
            {
                Name = nameTextBox.Text,
                Address = addressTextBox.Text,
                PhoneNumber = phoneTextBox.Text,
                Email = emailTextBox.Text
            };

            // Beállítja a dialógusablak DialogResult értékét igazra, hogy jelezze a sikeres műveletet
            DialogResult = true;

            // Bezárja a dialógusablakot
            Close();
        }

        // Ellenőrzi az e-mail cím formátumát
        private bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }

        private void CancelButton_Click(object sender, RoutedEventArgs e)
        {
            // Beállítja a dialógusablak DialogResult értékét hamisra, hogy jelezze a művelet megszakítását
            DialogResult = false;

            // Bezárja a dialógusablakot
            Close();
        }
    }
    public class Customer : INotifyPropertyChanged
    {
        private string name;
        public string Name
        {
            get { return name; }
            set
            {
                name = value;
                OnPropertyChanged("Name");
            }
        }

        private string address;
        public string Address
        {
            get { return address; }
            set
            {
                address = value;
                OnPropertyChanged("Address");
            }
        }

        private string phoneNumber;
        public string PhoneNumber
        {
            get { return phoneNumber; }
            set
            {
                phoneNumber = value;
                OnPropertyChanged("PhoneNumber");
            }
        }

        private string email;
        public string Email
        {
            get { return email; }
            set
            {
                email = value;
                OnPropertyChanged("Email");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }

    public partial class MainWindow : Window

    {
        private ObservableCollection<Customer> customers = new ObservableCollection<Customer>();

        public MainWindow()
        {
            InitializeComponent();
            InitializeData();
            DataContext = this;
        }

        private void InitializeData()
        {
            // Teszt adatok inicializálása
            customers.Add(new Customer { Name = "John Doe", Address = "123 Main St", PhoneNumber = "555-1234", Email = "john@example.com" });
            customers.Add(new Customer { Name = "Jane Smith", Address = "456 Elm St", PhoneNumber = "555-5678", Email = "jane@example.com" });
        }

        public ObservableCollection<Customer> Customers
        {
            get { return customers; }
        }

        private void AddCustomerButton_Click(object sender, RoutedEventArgs e)
        {
            // Dialógusablak megjelenítése az új ügyfél adatainak megadásához
            var dialog = new AddCustomerDialog();
            if (dialog.ShowDialog() == true)
            {
                // Az új ügyfél hozzáadása a listához
                customers.Add(dialog.Customer);
            }
        }
        private void DeleteCustomerButton_Click(object sender, RoutedEventArgs e)
        {
            // Ellenőrizzük, hogy van-e kijelölt ügyfél
            if (CustomersListBox.SelectedItem != null)
            {
                // Kérdezzük meg a felhasználót, hogy biztosan törölni szeretné-e az ügyfelet
                MessageBoxResult result = MessageBox.Show("Are you sure you want to delete this customer?", "Delete Customer", MessageBoxButton.YesNo, MessageBoxImage.Question);

                if (result == MessageBoxResult.Yes)
                {
                    // Kijelölt ügyfél törlése
                    customers.Remove((Customer)CustomersListBox.SelectedItem);
                }
            }
            else
            {
                // Ha nincs kijelölt ügyfél, jelenítse meg a figyelmeztető üzenetet
                MessageBox.Show("Please select a customer to delete.", "Delete Customer", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }
        private void SearchCustomers(string searchQuery)
        {
            // Ellenőrizzük, hogy a keresőkifejezés nem üres
            if (!string.IsNullOrEmpty(searchQuery))
            {
                // A keresőkifejezés alapján szűrjük az ügyfeleket
                var filteredCustomers = customers.Where(customer =>
                    customer.Name.Contains(searchQuery, StringComparison.OrdinalIgnoreCase) ||
                    customer.Address.Contains(searchQuery, StringComparison.OrdinalIgnoreCase) ||
                    customer.PhoneNumber.Contains(searchQuery, StringComparison.OrdinalIgnoreCase) ||
                    customer.Email.Contains(searchQuery, StringComparison.OrdinalIgnoreCase)
                );

                // Töltsük fel a ListBox-ot a szűrt ügyfelekkel
                CustomersListBox.ItemsSource = filteredCustomers;
            }
            else
            {
                // Ha a keresőkifejezés üres, visszaállítjuk az eredeti ügyfelek listáját
                CustomersListBox.ItemsSource = customers;
            }
        }
        private void SearchTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            TextBox searchTextBox = (TextBox)sender;
            string searchQuery = searchTextBox.Text;
            SearchCustomers(searchQuery);
        }
        private void ExportCustomersButton_Click(object sender, RoutedEventArgs e)
        {
            StringBuilder csvContent = new StringBuilder();

            // Fejléc hozzáadása a CSV fájlhoz
            csvContent.AppendLine("Name,Address,PhoneNumber,Email");

            // Ügyfelek adatainak hozzáadása a CSV fájlhoz
            foreach (Customer customer in Customers)
            {
                csvContent.AppendLine($"{customer.Name},{customer.Address},{customer.PhoneNumber},{customer.Email}");
            }

            // CSV fájl mentése
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "CSV files (*.csv)|*.csv|All files (*.*)|*.*";
            if (saveFileDialog.ShowDialog() == true)
            {
                string fileName = saveFileDialog.FileName;
                File.WriteAllText(fileName, csvContent.ToString());
                MessageBox.Show("Customers exported successfully!", "Export Customers", MessageBoxButton.OK, MessageBoxImage.Information);
            }

        }
        private void ImportCustomersButton_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "CSV files (*.csv)|*.csv|All files (*.*)|*.*";
            if (openFileDialog.ShowDialog() == true)
            {
                string fileName = openFileDialog.FileName;

                try
                {
                    // CSV fájl beolvasása
                    string[] lines = File.ReadAllLines(fileName);

                    // Az első sor a fejléc, ezért kihagyjuk
                    for (int i = 1; i < lines.Length; i++)
                    {
                        string[] fields = lines[i].Split(',');
                        if (fields.Length >= 4)
                        {
                            Customer customer = new Customer
                            {
                                Name = fields[0],
                                Address = fields[1],
                                PhoneNumber = fields[2],
                                Email = fields[3]
                            };

                            // Hozzáadjuk az ügyfelet a listához
                            Customers.Add(customer);
                        }
                    }

                    MessageBox.Show("Customers imported successfully!", "Import Customers", MessageBoxButton.OK, MessageBoxImage.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error while importing customers: {ex.Message}", "Import Customers", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
        }
        private void EditCustomerButton_Click(object sender, RoutedEventArgs e)
        {
            // Ellenőrizzük, hogy van-e kijelölt ügyfél
            if (CustomersListBox.SelectedItem != null)
            {
                // Az aktuális kijelölt ügyfél
                Customer selectedCustomer = (Customer)CustomersListBox.SelectedItem;

                // Dialógusablak megnyitása az ügyfél szerkesztéséhez
                var editDialog = new AddCustomerDialog();
                editDialog.Title = "Edit Customer";
                editDialog.nameTextBox.Text = selectedCustomer.Name;
                editDialog.addressTextBox.Text = selectedCustomer.Address;
                editDialog.phoneTextBox.Text = selectedCustomer.PhoneNumber;
                editDialog.emailTextBox.Text = selectedCustomer.Email;

                if (editDialog.ShowDialog() == true)
                {
                    // Frissítsük az ügyfél adatait az új adatokkal
                    selectedCustomer.Name = editDialog.nameTextBox.Text;
                    selectedCustomer.Address = editDialog.addressTextBox.Text;
                    selectedCustomer.PhoneNumber = editDialog.phoneTextBox.Text;
                    selectedCustomer.Email = editDialog.emailTextBox.Text;
                }
            }
            else
            {
                MessageBox.Show("Please select a customer to edit.", "Edit Customer", MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }
        



    }
}


