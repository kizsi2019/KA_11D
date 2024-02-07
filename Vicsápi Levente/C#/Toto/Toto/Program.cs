using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Toto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //2.feladat
            List<EredmenyElemzo> eredmenyek = new List<EredmenyElemzo>(2000);

            foreach (var item in File.ReadAllLines("toto.txt").Skip(1))
            {
                eredmenyek.Add(new EredmenyElemzo(item));
            }

            //3.feladat
            int adatok_szama = 0;
            for(int i = 0; i < eredmenyek.Count; i++)
            {
                adatok_szama++;
            }
            Console.WriteLine($"3.feladat: Fofdulók száma: {adatok_szama}");

            //4.feladat
            int nyertes_szelveny_szam = 0;
            for(int i = 0;i < eredmenyek.Count;i++)
            {
                nyertes_szelveny_szam += eredmenyek[i].T13pl;
            }

            Console.WriteLine($"4.feladat: Telitalálatos szelvények száma: {nyertes_szelveny_szam} db");

            //5.feladat
            

            //6.feladat
            Dictionary<string, string> szotár = new Dictionary<string, string>();
            Dictionary<string, string> szotár2 = new Dictionary<string, string>();

            var max = eredmenyek[0].Ny13pl;
            int legnagyobb_ev = 0;
            int legnagyobb_het = 0;
            int Fordulo = 0;
            int telitalalat = 0;
            string Eredmeny = "";

            for(int i = 0; i < eredmenyek.Count; i++)
            {
                if (eredmenyek[i].Ny13pl > max)
                {
                    max = eredmenyek[i].Ny13pl;
                    legnagyobb_ev = eredmenyek[i].Ev;
                    legnagyobb_het = eredmenyek[i].Het;
                    Fordulo = eredmenyek[i].Fordulo;
                    Eredmeny = eredmenyek[i].Eredmenyek;
                    telitalalat = eredmenyek[i].T13pl;
                }
                
            }

            Console.WriteLine();
            Console.WriteLine("6.feladat:");
            Console.WriteLine("\tLegnagyobb:");
            szotár.Add("Év:", legnagyobb_ev.ToString());
            szotár.Add("Hét:", legnagyobb_het.ToString() + ".");
            szotár.Add("Forduló:", Fordulo.ToString() + ".");
            szotár.Add("Telitalálat:", telitalalat.ToString() + "db");
            szotár.Add("Nyeremény:", max.ToString() + " Ft");
            szotár.Add("Eredmények:", Eredmeny);

            foreach (var item in szotár)
            {
                Console.WriteLine($"\t{item.Key} {item.Value}");
            }

            var min = eredmenyek[10].Ny13pl;
            int legkisebb_ev = 0;
            int legkisebb_het = 0;
            int Fordulo2 = 0;
            int telitalalat2 = 0;
            string Eredmeny2 = "";

            for(int i = 0; i < eredmenyek.Count; i++)
            {
                if (eredmenyek[i].Ny13pl < min && eredmenyek[i].Ny13pl > 0)
                {
                    min = eredmenyek[i].Ny13pl;
                    legkisebb_ev = eredmenyek[i].Ev;
                    legkisebb_het = eredmenyek[i].Het;
                    Fordulo2 = eredmenyek[i].Fordulo;
                    Eredmeny2 = eredmenyek[i].Eredmenyek;
                    telitalalat2 = eredmenyek[i].T13pl;
                }
            }

            Console.WriteLine();
            Console.WriteLine("\tLegkisebb:");
            szotár2.Add("Év:", legkisebb_ev.ToString());
            szotár2.Add("Hét:", legkisebb_het.ToString() + ".");
            szotár2.Add("Forduló:", Fordulo2.ToString() + ".");
            szotár2.Add("Telitalálat:", telitalalat2.ToString() + " db");
            szotár2.Add("Nyeremény:", min.ToString() + " Ft");
            szotár2.Add("Eredmények:", Eredmeny2);

            foreach (var item in szotár2)
            {
                Console.WriteLine($"\t{item.Key} {item.Value}");
            }

            //7.feladat
            Console.WriteLine();
            bool nemvoltDontetlenMerkozes = false;

            for (int i = 0; i < eredmenyek.Count; i++)
            {
                if (eredmenyek[i].NemvoltDontetlenMerkozes)
                {
                    nemvoltDontetlenMerkozes = true;
                    break;
                }
            }
            if (nemvoltDontetlenMerkozes)
            {
                Console.WriteLine("7.feladat: Nem volt döntetelen nélküli mérkőzés.");
            }

            //8.feladat
            Console.WriteLine();
            bool dontetelenNelkuliMerkozes = false;
            for(int i = 0;i < eredmenyek.Count;i++)
            {
                if (!eredmenyek[i].Eredmenyek.Contains("X"))
                {
                    dontetelenNelkuliMerkozes = true;
                    break;
                }
            }
            if (dontetelenNelkuliMerkozes)
            {
                Console.WriteLine("8.feladat: Volt döntetlen nélküli foduló!");
            }
            Console.ReadKey();
        }
    }
}
