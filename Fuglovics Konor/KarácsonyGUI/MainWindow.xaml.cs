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

namespace KarácsonyGUI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow: Window
    {
        public MainWindow()
        {
            InitializeComponent();
            if (cbDay.Items.Count < 40)
            {
                cbDay.Items.Clear();
                for (int i = 1; i <= 40; i++)
                {
                    cbDay.Items.Add(i);
                }
            }
        }
        public static int day = 0, done = 0, sold = 0, total = 0;

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            done = Convert.ToInt32(tbMade.Text);
            sold = Convert.ToInt32(tbSold.Text);
            if (done < 0 || sold < 0)
            {
                lblError.Content = "Cannot be negative!";
            }
            else if (sold > done + total)
            {
                lblError.Content = "Too much angels sold!";
            }
            else
            {
                day = Convert.ToInt32(cbDay.SelectedItem.ToString());
                total += done - sold;
                tbOutput.Text += $"Day {day}: \t" + done + "\t-" + sold + " \t= \t" + total + "\n";
            }
            for (int i = 1; i < day; i++)
            {
                cbDay.Items.Remove(i);
            }
            tbMade.Text = "0";
            tbSold.Text = "0";
            lblError.Content = "";
        }
    }
}
