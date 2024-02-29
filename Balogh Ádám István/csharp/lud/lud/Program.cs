using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace lud
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1.feladat
            List<string> dobasok = new List<string>();
            List<string> osvenyek = new List<string>();

            foreach (var sor in File.ReadAllLines("dobasok.txt")) 
            {
                dobasok.Add(sor);
            }

            foreach (string sor in File.ReadAllLines("osvenyek.txt"))
            {
                osvenyek.Add(sor);
            }

            //2.feladat
            Console.WriteLine("2.feladat");

            string[] m = new string[2000];
            foreach (string sor in dobasok)
            {
                m = sor.Split(' ');
            }

            Console.WriteLine($"A dobások száma: {m.Length}");

            int osvenyek_szama = 0;
            foreach (string sor in osvenyek)
            {
               if( sor != "")
               {
                 osvenyek_szama++;
               }
            }

            Console.WriteLine($"Az ösvények száma: {osvenyek_szama}");

            //3.feladat
            Console.WriteLine();
            Console.WriteLine("3.feladat");
 
            var max = osvenyek[0].Length;
            int legnagyobbInex = 0;

            for (int i = 0; i < osvenyek.Count; i++)
            {
               
               if (osvenyek[i].Length > max)
               {
                  max = osvenyek[i].Length;
                  legnagyobbInex = i;
               }
            }

            Console.WriteLine($"Az egyik leghosszabb a(z) {legnagyobbInex + 1}.ösvény, hossza {max}");

            //4.feladat
            Console.WriteLine();
            Console.WriteLine("4.feladat");

            Console.Write("Adja meg az ösvény sorszámát! ");
            int osvenySorszama = Convert.ToInt32(Console.ReadLine());

            Console.Write("Adja meg a játékosok számát! ");
            int jatekosokSzama = Convert.ToInt32(Console.ReadLine());

            //5.feladat
            Console.WriteLine();
            Console.WriteLine("5.feladat");

            List<string> osveny = new List<string>();

            osveny.Add(osvenyek[osvenySorszama - 1]);

            int mBetukSzama = 0;
            int vBetukSzama = 0;
            int eBetukSzama = 0;

            foreach(string s in osveny)
            {
                foreach(char c in s) 
                {
                    if (c == 'M')
                    {
                        mBetukSzama++;
                    }

                    if (c == 'V')
                    {
                        vBetukSzama++;
                    }

                    if(c == 'E')
                    {
                        eBetukSzama++;
                    }
                }
            }

            Console.WriteLine($"M: {mBetukSzama} darab");
            Console.WriteLine($"V: {vBetukSzama} darab");
            Console.WriteLine($"E: {eBetukSzama} darab");

            //6.feladat
            Console.WriteLine();

            StreamWriter sw = new StreamWriter("kulonleges.txt");
            int sorszam = 0;

            foreach(string s in osveny)
            {
                foreach (char c in s)
                {
                    sorszam++;
                    sw.WriteLine($"{c}\t{sorszam}");
                }
            }
            sw.Close();

            //7.feladat
            Console.WriteLine();

            
            
            Console.ReadKey();
        }
    }
}
