﻿using System;
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


namespace nobeldijasok
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

        private void btnMentes_Click(object sender, RoutedEventArgs e)
        {
            if(tbEv.Text !="" && tbNev.Text !="" && tbSzulHal.Text !="" && tbOrszag.Text != "")
            {
                if(int.Parse(tbEv.Text) <= 1989)
                {
                    MessageBox.Show("Hiba! Az évszám nem megfelelő!", "Mentés");
                }
                try
                {
                    List<string> kimenet = new List<string>();
                    kimenet.Add("Év;Név;SzületésHalálozás;Országkód");
                    kimenet.Add($"{tbEv.Text}; {tbNev.Text}; {tbSzulHal.Text}; {tbOrszag.Text}");
                    File.WriteAllLines("uj_dijazott.txt", kimenet);
                    tbEv.Text = "";
                    tbNev.Text = "";
                    tbSzulHal.Text = "";
                    tbOrszag.Text = "";

                }
                catch (System.Exception)
                {

                    MessageBox.Show("Hiba! Az állomány írásánál!");
                }
            }
            else
            {
                MessageBox.Show("Töltsön ki mineden mezőt!", "Mentés");
            }
        }
    }
}
