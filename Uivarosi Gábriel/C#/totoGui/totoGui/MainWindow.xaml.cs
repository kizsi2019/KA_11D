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

namespace totoGui
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void Input_box_TextChanged(object sender, TextChangedEventArgs e)
        {
            Caracter_szám_X.IsChecked = Input_box.Text.Length != 14;
            Caracter_szám_X.Content = $"Nem megfelelő a Karacterek száma ({Input_box.Text.Length})";
        }

        private void Save_button_Click(object sender, RoutedEventArgs e)
        {

        }

  
    }
}
