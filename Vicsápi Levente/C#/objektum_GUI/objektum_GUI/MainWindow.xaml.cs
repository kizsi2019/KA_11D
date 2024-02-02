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

namespace objektum_GUI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Tartalmak> tartalmak = new List<Tartalmak>();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int tartalom = Convert.ToInt32(tbBevitel.Text);

                if (tbBevitel.Text != "")
                {
                    tartalmak.Add(new Tartalmak(tartalom.ToString()));
                    tbTartalom.Text = "";
                    errorText.Text = "";

                    foreach (var item in tartalmak)
                    {
                        tbTartalom.Text += item.Tartalom.ToString() + Environment.NewLine;
                    }
                }
            }
            catch (Exception)
            {
                errorText.Text = "A mezőbe legalább egy számot meg kell adni, betű nem lehet!";
                errorText.Visibility = Visibility.Visible;
            }
            
        }
    }
}
