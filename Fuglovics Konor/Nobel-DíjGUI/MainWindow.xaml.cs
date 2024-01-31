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
using System.IO;

namespace Nobel_DíjGUI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow: Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (tbYear.Text != "" && tbName.Text != "" && tbBornDth.Text != "" && tbCountry.Text != "")
            {
                if (int.Parse(tbYear.Text) >= 1989)
                {
                    MessageBox.Show("The specified year is bigger than 1989!", "Error");
                }
                try
                {
                    List<string> output = new List<string>();
                    output.Add("Year;Name;BornDeath;CountryCode");
                    output.Add($"{tbYear.Text};{tbName.Text};{tbBornDth.Text};{tbCountry.Text}");
                    File.WriteAllLines("uj_dijjazott.txt", output);
                    tbYear.Text = "";
                    tbName.Text = "";
                    tbBornDth.Text = "";
                    tbCountry.Text = "";
                }
                catch (System.Exception)
                {

                    MessageBox.Show("Format error!");
                }
            }
            else
            {
                MessageBox.Show("Please fill in all fields!", "Error");
            }
        }
    }
}
