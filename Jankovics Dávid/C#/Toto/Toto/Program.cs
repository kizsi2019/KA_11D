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
            List<Csekold_Le> szamok = new List<Csekold_Le>(2000);

            foreach (var item in File.ReadAllLines("toto.txt").Skip(1))
            {
                szamok.Add(new Csekold_Le(item));
            }

            int adatok = 0;
            for(int i = 0; i < szamok.Count; i++)
            {
                adatok++;
            }
            Console.WriteLine($"3.feladat: Fofdulók száma: {adatok}");

            int telitalalatos_szelveny_szam = 0;
            for(int i = 0;i < szamok.Count;i++)
            {
                telitalalatos_szelveny_szam += szamok[i].T13p1;
            }

            Console.WriteLine($"4.feladat: Telitalálatos szelvények száma: {telitalalatos_szelveny_szam} db");


            
            var max = szamok[0].Ny13p1;
            int legnagyobb_ev = 0;
            int legnagyobb_het = 0;
            int Fodulo = 0;
            string Eredmeny = 0;

            for(int i = 0; i < szamok.Count; i++)
            {
                if (szamok[i].Ny13p1 > max)
                {
                    max = szamok[i].Ny13p1;
                    legnagyobb_ev = szamok[i].Ev;
                    legnagyobb_het = szamok[i].Het;
                    Fodulo = szamok[i].Fordulo;
                    Eredmeny = szamok[i].Eredmenyek;
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
