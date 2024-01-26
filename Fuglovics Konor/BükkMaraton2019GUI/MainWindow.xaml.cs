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

namespace BükkMaraton2019GUI
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

        private void btnCalculate_Click(object sender, RoutedEventArgs e)
        {
            int[] length = { 16000, 38000, 54000, 57000, 94000 };
            string[] m = tbIdo.Text.Split(':');
            int hour = int.Parse(m[0]);
            int minute = int.Parse(m[1]);
            int second = int.Parse(m[2]);
            int TotalTime = hour * 3600 + minute * 60 + second;
            int distance = length[cbTav.SelectedIndex];
            double AverageKmpH = Math.Round(((1.0) * distance / TotalTime) * 3.6, 2);
            double AverageMpS = Math.Round(((1.0) * distance / TotalTime), 2);
            tbAtlagSebessegKmPh.Text = AverageKmpH.ToString();
            tbAtlagSebessegMPS.Text = AverageMpS.ToString();
        }
    }
}
