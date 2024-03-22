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
            public decimal Amount { get; set; }
            public string Type { get; set; }
            public string Description { get; set; }
        }

        private ObservableCollection<BudgetItem> budgetItems = new ObservableCollection<BudgetItem>();

        public MainWindow()
        {
            InitializeComponent();
            DataGrid.ItemsSource = budgetItems;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            BudgetItem newItem = new BudgetItem
            {
                Amount = decimal.Parse(TbMoney.Text),
                Type = CbType.Text,
                Description = TbDesc.Text
            };

            // Add hozzá az új tételt az adatforráshoz
            budgetItems.Add(newItem);

            // Töröld ki a TextBox-ok tartalmát
            TbMoney.Text = "";
            CbType.SelectedIndex = -1;
            TbDesc.Text = "";

        }
    }
}
