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
using System.Security.Cryptography.X509Certificates;

namespace quiz_game
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
             List<string> Bemenet = new List<string>();

            foreach (string line in File.ReadLines("import.txt"))
            {
                Bemenet.Add(line);
            }
       
            int kérdés_szám = 0;
            double Jól_megadot_válaszok = 0;
            double megoldás_százalék = 0;
            string Jelenlegi_Válasz = "";
            //Make Functont to separate
            string[] szep1;
            string Maga_A_kérdés = "";
            string A_válasz = "";
            string B_Válasz = "";
            string C_Válasz = "";
            string Helyes_Válasz_index = ""; 
            string Helyes_Válasz_ABC = "";
             void Szeparálás()
            {
                szep1 = Bemenet[kérdés_szám].Split(';');
                Maga_A_kérdés = szep1[0];
                A_válasz = szep1[1];
                B_Válasz = szep1[2];
                C_Válasz = szep1[3];
                Helyes_Válasz_index = szep1[4];
          
            
            }
            Szeparálás();   
            Ki_írás();
            void Ki_írás() {
                X_KérdésTB.Text = kérdés_szám+1 + " "+ "Kérdés";
                Kérdés_tb.Text = Maga_A_kérdés;
                Textbox_A.Text = A_válasz;
                Textbox_B.Text = B_Válasz;
                Textbox_C.Text = C_Válasz;


            }

            bool tesz_kész = false;



            Button_A.Click += (sender, e) =>
            {
       
                Jelenlegi_Válasz = "1";
               Csekolás();
            };

            Button_B.Click += (sender, e) =>
            {
        
                Jelenlegi_Válasz = "2";
                Csekolás();
            };

            Button_C.Click += (sender, e) =>
            {
            
                Jelenlegi_Válasz = "3";
                Csekolás();
            };

            void százalék_kiírás()
            {
                megoldás_százalék =  (Jól_megadot_válaszok / 15) * 100;
                megoldás_százalék = Math.Round(megoldás_százalék); 
                Correct_ans_text.Text = "A Helyes Válaszok százaléka:";
              string megoldás_százalék_tx = megoldás_százalék.ToString();
                Correct_ans_num.Text = megoldás_százalék_tx + "%";
            }

            void Csekolás()
            {

                if (Jelenlegi_Válasz == Helyes_Válasz_index && tesz_kész == false)
                {
                    Jól_megadot_válaszok++;

                }
                if (tesz_kész == false)
                {
                    kérdés_szám++;
                    Szeparálás();
                    Ki_írás();
                } 
                
                if (kérdés_szám >= 14)
                {
                    tesz_kész = true;
                    százalék_kiírás();
                }
          
        }

         


        }


    }

    }

