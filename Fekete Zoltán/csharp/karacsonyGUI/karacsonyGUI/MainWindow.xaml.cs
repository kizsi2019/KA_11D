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

namespace karacsonyGUI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            if (cbNap.Items.Count < 40)
            {
                cbNap.Items.Clear();
                for (int i = 1; i <= 40; i++)
                {
                    cbNap.Items.Add(i);
                }
            }
        }

        public static int nap = 0, kesz = 0, eladott = 0, ossz = 0;
        private void btnHozzaad_Click(object sender, RoutedEventArgs e)
        {
            kesz = Convert.ToInt32(tbElkeszitett.Text);
            eladott = Convert.ToInt32(tbEladott.Text);
            if (kesz < 0 || eladott < 0)
            {
                lblHiba.Content = "Negatív számot adott meg!";
            }
            else if (eladott > kesz + ossz)
            {
                lblHiba.Content = "Túl sok az eladott angyalka!";
            }
            else
            {
                nap = Convert.ToInt32(cbNap.SelectedItem.ToString());
                ossz += kesz - eladott;
                tbKimenet.Text += nap + ". nap: \t" + kesz + "\t-" + eladott + " \t= \t" + ossz + "\n";
                for (int i = 0; i < nap; i++)
                {
                    cbNap.Items.Remove(i);
                }
                tbElkeszitett.Text = "0";
                tbEladott.Text = "0";
                lblHiba.Content = "";
            }
        }
    }
}
