using System;
using System.Collections.Generic;
using System.IO;
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

namespace emberekGUI
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

        List<Adatok> adatok = new List<Adatok>();

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            StreamWriter sr = new StreamWriter("Ember.txt");

            try
            {
                string nev = tbNev.Text;
                string kor = tbKor.Text;
                string varos = tbVáros.Text;
                string eredmeny = "";

                adatok.Add(new Adatok(nev, kor, varos));

                foreach (var item in adatok)
                {
                    eredmeny += item.Nev.ToString() + ";" + item.Kor.ToString() + ";" + item.Varos.ToString() + Environment.NewLine;   
                }
                sr.WriteLine(eredmeny);
                tbNev.Text = ""; 
                tbKor.Text = ""; 
                tbVáros.Text = "";
                sr.Close();
                
                MessageBox.Show("A fájlba írás sikeres volt!", "Az írás befejeződött!");
            }
            catch (Exception)
            {

                MessageBox.Show("Hiba történt a fájl írása során!", "Hiba");
            }
            
        }
    }
}
