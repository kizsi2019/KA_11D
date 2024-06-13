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

namespace toto.apf
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private object txbInput;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Ellenorzes(object sender, RoutedEventArgs e)
        {
            int hossz = txbInput.Text.Length;
            if (hossz != 14)
            {
                cbxHossz.IsChecked = true;
            }
            cbxHossz.Content = $"Nem megfelelő a karakterek száma({hossz})";
        }
    }
}
