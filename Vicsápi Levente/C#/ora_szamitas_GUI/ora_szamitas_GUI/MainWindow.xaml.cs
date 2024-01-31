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

namespace ora_szamitas_GUI
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string[] ido = Ido.Text.Split(":");
            int ora = int.Parse(ido[0]);
            int perc = int.Parse(ido[1]);
            int mp = int.Parse(ido[2]);

            int eredmeny_perc = (ora * 60) + perc + (mp / 60);
            int eredmeny_mp = (ora * 3600) + (perc * 60) + mp;

            Perc.Text = eredmeny_perc.ToString();
            Mp.Text = eredmeny_mp.ToString();
        }
    }
}
