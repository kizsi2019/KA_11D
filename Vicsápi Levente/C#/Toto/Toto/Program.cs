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
            
            var max = eredmenyek[0].Ny13pl;
            bool legnagyobb = false;
            int legnagyobb_ev = 0;
            int legnagyobb_het = 0;
            int Fodulo = 0;
            string Eredmeny = 0;

            for(int i = 0; i < eredmenyek.Count; i++)
            {
                if (eredmenyek[i].Ny13pl > max)
                {
                    max = eredmenyek[i].Ny13pl;
                    legnagyobb = true;
                    legnagyobb_ev = eredmenyek[i].Ev;
                    legnagyobb_het = eredmenyek[i].Het;
                    Fodulo = eredmenyek[i].Fordulo;
                    Eredmeny = eredmenyek[i].Eredmenyek;
                }
            }

            Console.WriteLine(max);
            Console.WriteLine(legnagyobb_ev);
            Console.WriteLine(legnagyobb_het);
            Console.WriteLine(Fodulo);
            Console.WriteLine(Eredmeny);

            Console.ReadKey();
        }
    }
}
