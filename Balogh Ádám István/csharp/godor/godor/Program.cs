using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace godor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StreamReader reader = new StreamReader("melyseg.txt");

            string[] melysegek = new string[2000];
            int index = 0;

            string line = reader.ReadLine();
            Console.WriteLine(line);

            int adatokSzama = 0;
            while (line != null) 
            {
                adatokSzama++;
                melysegek[index] = line;
                index++;
                line = reader.ReadLine();
            }
            reader.Close();

            Console.WriteLine("1.feladat");
            Console.WriteLine($"A fájl adatainak száma: {adatokSzama}");

            Console.Write("Adjon meg egy távolságértéket! ");
            int tavolsagErtek = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine();

            Console.WriteLine("2.feladat");
            Console.WriteLine($"Ezen a helyen a felszín {melysegek[tavolsagErtek]} méter mélyen van");


            StreamWriter writer = new StreamWriter("godrok.txt");

            for(int i = 1; i < melysegek.Length; i++)
            {
                if (melysegek[i] != "0")
                {
                    writer.Write(melysegek[i] + " ");
                }

                else
                {
                    if (melysegek[i - 1] != "0")
                    {
                        writer.WriteLine();
                    }
                }
                  
            }
            writer.Close();

            
            Console.WriteLine("5.feladat");
            int godrok_szama = 0;

            for(int i = 1;i < index; i++)
            {
                if(melysegek[i] != "0" && melysegek[i - 1] == "0") 
                {
                    godrok_szama++;
                }
            }


            Console.WriteLine($"A gödrök száma: {godrok_szama}");

            Console.ReadKey();
        }
    }
}
