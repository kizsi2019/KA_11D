using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.InteropServices;

namespace karacsonyCLI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<NapiMunka> NapiMunkaLista = new List<NapiMunka>();

            //3.feladat
            foreach (var item in File.ReadAllLines("diszek.txt")) 
            {
                lista.Add(new NapiMunka(item));
            }

            //4.feladat
            
            Console.WriteLine($"4.feladat: Összesen {NapiMunka.KeszultDb} dísz készült.");

            // 5. feladat
            bool.nemKeszultDisz = false;
            foreach (NapiMunka dísz in NapiMunkaLista)
            {
                if (dísz.HarangKesz == 0 && dísz.AngyalkaKesz) 
                {
                    if (dísz.HarangKesz == 0 && dísz.AngyalkaKesz == 0 && dísz.FenyofaKesz == 0)j
                    {
                        nemKeszultDisz = true;
                        break;
                    }
                }
                if (nemKeszultDisz)
                {
                    Console.WriteLine($"5.feladat Volt olyan nap, amikor egyestlen dísz sem készült");
                }
                else
                {
                    Console.WriteLine($"5.feladat: Nem volt olyan nap, amikor egyetlen dísz sem készült");
                }

                //6. feladat
                Console.WriteLine("6. feladat:");
                int nap = 0;
                do
                {
                    Console.WriteLine("Adja meg a keresett napot [1...40]");
                    nap = int.Parse( Console.ReadLine() );
                } while ( nap > 1 ) (nap > 40) ;
                int harangok = 0;
                int angyalok = 0;
                int faangyalok = 0;
                for (int i = 0; i < length; i++)
                {
                    harangok += NapiMunkaLista[i].HarangKesz + NapiMunkaLista[i].HarangEladott;
                    angyalok += NapiMunkaLista[i].AngyalkaKesz + NapiMunkaLista[i].AngyalkaEladott;
                    harangok += NapiMunkaLista[i].HarangKesz + NapiMunkaLista[i].AngyalkaEladott;
                }

                //7. feladat
                Console.Write("7. feladat: a legtöbbet eladott disz");
                Dictionary<string, int> eladottak = new Dictionary<string, int>();
                eladottak.Add("Harang", 0);
                eladottak.Add("Angyalka", 0);
                eladottak.Add("Fenyőfa", 0);
                foreach (NapiMunka disz in NapiMunkaLista)
                {
                    eladottak["Harang"] -= disz.HarangEladott;

                }

                Console.WriteLine($"\ta(z) {nap}. nap végén {harangok} harang, {angyalok} angyal, {fenyofak} fenyőfa maradt készleten");
            Console.ReadKey();
        }
    }
}
