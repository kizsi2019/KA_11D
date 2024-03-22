using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.IO;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Recept_Kezelő
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            
            

            InitializeComponent();

           
          
            bool felhasz_létezik = false;
            Felhasználó_váltás_Button.Click += (sender, e) =>
            {
                felhasznáóváltás();
              
            };
            void felhasznáóváltás()
            {
                bool foreach_lefutot = false;
                string line_fel = "";
                string line_Jel = "";
                foreach (string line in File.ReadLines("felhasználók.txt"))
                {
                    string[] Line_sp = line.Split(';');
                    line_fel = Line_sp[0];
                    
                    line_Jel = Line_sp[1];
                    if (Bejelt_Név_TxBlox.Text == line_fel)
                    {
                        if (line_Jel == Jelszó_txbox.Text)
                        {
                            Felhasználó_Név_txBlock.Text = line_fel;
                            Bejelt_Név_TxBlox.Text = "";
                            Jelszó_txbox.Text = "";
                            foreach_lefutot = true;
                            Error_txblock.Text = "Sikeres Bejelentkezés";
                            break;
                        }
                        else
                        {
                            Error_txblock.Text = "Hejtelen Jelszó";
                            foreach_lefutot = true;
                            break;

                        }
                    }   }
                    if (foreach_lefutot == false)
                        {
                            using (StreamWriter writer = new StreamWriter("felhasználók.txt", true))
                            {
                                // Write to a new line
                                writer.WriteLine(Bejelt_Név_TxBlox.Text + ";" + Jelszó_txbox.Text);

                            }
                        Felhasználó_Név_txBlock.Text = Bejelt_Név_TxBlox.Text;
                    Error_txblock.Text = "Sikeres registráció";
                    Bejelt_Név_TxBlox.Text = "";
                            Jelszó_txbox.Text = "";
                            
                        }



            }


        }


    }
}
