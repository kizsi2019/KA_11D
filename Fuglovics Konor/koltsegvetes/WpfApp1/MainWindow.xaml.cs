using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Collections.ObjectModel;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow: Window
    {
        public class BudgetItem
        {
            public int Mennyiség { get; set; }
            public string Típus { get; set; }
            public string Leírás { get; set; }
        }

        private ObservableCollection<BudgetItem> budgetItems = new ObservableCollection<BudgetItem>();

        public MainWindow()
        {
            InitializeComponent();
            TbMoney.Text = "";
            CbType.SelectedIndex = -1;
            TbDesc.Text = "";
            DataGrid.ItemsSource = budgetItems;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            BudgetItem newItem = null;
            try
            {
                newItem = new BudgetItem
                {
                    Mennyiség = int.Parse(TbMoney.Text),
                    Típus = CbType.Text,
                    Leírás = TbDesc.Text
                };
            }
            catch (FormatException)
            {
                MessageBox.Show($"A mezők nem lehetnek üresek!.", "Hiba!", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            // Add hozzá az új tételt az adatforráshoz
            budgetItems.Add(newItem);
            UpdateTotalAmount();

            // Töröld ki a TextBox-ok tartalmát
            TbMoney.Text = "";
            CbType.SelectedIndex = -1;
            TbDesc.Text = "";

            void UpdateTotalAmount()
            {
                int totalAmount = 0;

                foreach (var item in budgetItems)
                {
                    if (item.Típus == "Bevétel")
                    {
                        totalAmount += item.Mennyiség;
                    }
                    if (item.Típus == "Kiadás")
                    {
                        totalAmount -= item.Mennyiség;
                    }
                }

                LblTotal.Content = $"{totalAmount.ToString()} Ft";
            }
        }
    }
}
