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
            string Előzmények_tx = "";
            string[] tag_split_keres;
            string tag_ker;
            bool ilyen_tag_van;
            bool ilyen_recept_van = false;
            string jelenlegi_recept_Keresés;
            string jelenlegi_tag_keresés;
            string tages_receptek;
            Keresés_button.Click += (sender, e) =>
            {
                Combo_box.Items.Clear();
                Keresés();
            };

           void Keresés()
            {
                ilyen_tag_van = false;
                 ilyen_recept_van = false;
                foreach (string item in File.ReadLines("receptek_listája.txt"))
                {
                    if (Keresési_mező_txBox.Text == item)
                    {
                        jelenlegi_recept_Keresés = item;
                        ilyen_recept_van = true;
                        
                        recept_megnyitás();
                        break;
                    }
                }
                
                if (ilyen_recept_van == false) { 
                    foreach (string tag in File.ReadLines("tagek.txt"))
                    {
                      
                        tag_split_keres = tag.Split(";");
                       
                        tag_ker = tag_split_keres[0];
                        if (tag_ker == Keresési_mező_txBox.Text)
                        {
                            tages_receptek = tag_split_keres[1];
                            ilyen_tag_van = true;
                            jelenlegi_tag_keresés = tag_ker;
                            tag_ajánlások();
              
                            break;
                            
                        }
                    }
                }
                if (ilyen_recept_van == false && ilyen_tag_van == false)
                    {
                        MessageBox.Show("Ilyen Receptet vagy címkét nem Találtunk :(");
                    }





                Előzmények();


            }
            void Előzmények()
            {
                Előzmények_tx =  Előzmények_tx + " " + Keresési_mező_txBox.Text;
                Előzmények_txBlock.Text = Előzmények_tx;

            }
            string recept_path;
            string recept_szöveg;
            string[] recept_split;
            string recept_név;
            string recept_fogás;
            string recept_tag;
            void recept_megnyitás()
            {
                recept_path = "./Receptek/" + jelenlegi_recept_Keresés + ".txt";
                recept_split = File.ReadAllText(recept_path).Split(";");
                recept_név = recept_split[0];
                recept_fogás = recept_split[1];
                recept_tag = recept_split[2];
                recept_szöveg = recept_split[3];


                Recept_Mező_Textbox.Text = recept_szöveg;
                Categóri_txBlock.Text = recept_fogás;
                Recept_tag_tblock.Text = recept_tag;

            }

            void tag_ajánlások()
            {
                string[] combo_split = tages_receptek.Split(",");
                int combo_count = tages_receptek.Split(",").Count();
                for (int i =  0; i < combo_count; i++)
                {
                    Combo_box.Items.Add(combo_split[i]);
                }
            }
        }///


    }
}
