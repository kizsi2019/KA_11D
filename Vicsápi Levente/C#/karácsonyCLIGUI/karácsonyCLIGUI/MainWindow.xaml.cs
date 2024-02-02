using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;

namespace karácsonyCLIGUI
{
    public partial class MainWindow : Window
    {
        List<Angyalka> eredmenyek = new List<Angyalka>();

        public MainWindow()
        {
            InitializeComponent();
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int[] napok = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31, 32, 33, 34, 35, 36, 37, 38, 39, 40 };

            try
            {
                int nap = napok[cbNapszam.SelectedIndex];
                int elkeszitett = Convert.ToInt32(tbElkeszitett.Text);
                int eladott = Convert.ToInt32(tbEladott.Text);
                int maradt = elkeszitett - eladott;

                if (tbElkeszitett.Text != "" && tbEladott.Text != "" && elkeszitett >= 0 && eladott >= 0 && elkeszitett >= eladott)
                {
                    eredmenyek.Add(new Angyalka(nap.ToString(), elkeszitett.ToString(), eladott.ToString(), maradt.ToString()));
                    UpdateEredmenyekTextBox();
                    errorText.Text = "";
                }

                if(elkeszitett  < 0 || eladott < 0)
                {
                    errorText.Text = "Egyik szám se lehet negatív!";
                    errorText.Visibility = Visibility.Visible;
                }

                if(elkeszitett < eladott) 
                {
                    errorText.Text = "Túl sok az eladott angyalka!";
                    errorText.Visibility = Visibility.Visible;
                }
            }
            catch (System.Exception)
            {
                errorText.Text = "Töltsön ki minden mezőt!";
                errorText.Visibility = Visibility.Visible;
            }

            
        }

        private void UpdateEredmenyekTextBox()
        {
            tbEredmeny.Text = ""; // Töröljük a TextBox tartalmát, hogy ne csak az utolsó elem maradjon meg

            foreach (var item in eredmenyek)
            {
                tbEredmeny.Text += item.Nap + "\t" + item.Elkeszitett + "\t" + "-" + item.Eladott + "\t" + "=" + "\t" + item.Maradt + Environment.NewLine;
            }
        }
    }
}
