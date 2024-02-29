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

namespace KaracsonyGUI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            if (CbNap.Items.Count < 40)
            {
                CbNap.Items.Clear();
                for(int i = 1; i <= 40; i++)
                {
                    CbNap.Items.Add(i);
                }
            }
        }
        public static int nap = 0, kesz = 0, eladott = 0, ossz = 0;
        private void Hozza_add_buttun_Click(object sender, RoutedEventArgs e)
        {
             kesz = Convert.ToInt32(CbEllkeszitet.Text);
             eladott = Convert.ToInt32(CbElladott.Text);
            if (kesz < 0|| eladott < 0)
            {
                Lb_hiba.Content = "Negatív számot adott meg!";
            }
            else if (eladott < kesz + ossz)
            {
                Lb_hiba.Content = "Túl sok az eladott angyalka!";
            }
            else
            {
                nap = Convert.ToInt32(CbNap.SelectedItem.ToString());
                ossz += kesz - eladott;
                tx_output.Text += nap + "nap \t" + eladott + " \t = \t" + ossz + "\n";
                for (int i = 1; i < nap; i++)
                {
                    CbNap.Items.Remove(i);
             
                }
                CbEllkeszitet.Text = "0";
                CbElladott.Text = "0";
                Lb_hiba.Content = "";
            }

        }
    }
}
