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

namespace WpfApp1
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

        private void btnSzamol_Click(object sender, RoutedEventArgs e)
        {
            int[] tav = { 16000, 38000, 54000, 57000, 94000 };
            string[] m = tbIdo.Text.Split(':');
            int ora = int.Parse(m[0]);
            int perc = int.Parse(m[1]);
            int mp = int.Parse(m[2]);
            int osszido = ora * 3600 + perc * 60 + mp;
            int tavolsag = tav[cbTav.SelectedIndex];
            double atlagkmph = Math.Round(((1.0) * tavolsag / osszido) * 3.6, 2);
            double atlagmps = Math.Round(((1.0) * tavolsag / osszido), 2);
            tbAtlagSebessegKmPH.Text = atlagkmph.ToString();
            tbAtlagSebessegMPS.Text = atlagmps.ToString();
        }

    }
}
