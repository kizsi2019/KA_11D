using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace karacsonyCLI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<NapiMunka> diszek = new List<NapiMunka>();
            foreach (string sor in File.ReadAllLines("diszek.txt"))
            {
                diszek.Add(new NapiMunka(sor));
            }
            // 4. feladat
            Console.WriteLine($"4. feladat: Összesen {NapiMunka.KeszultDb} darab dísz készült.");

            //5. feladat
            bool nemKeszultDisz = false;
            foreach (NapiMunka dísz in diszek)
            {
                if (dísz.HarangKesz == 0 && dísz.AngyalkaKesz == 0 && dísz.FenyofaKesz == 0)
                {
                    nemKeszultDisz = true;
                    break;
                }
            }
            if (nemKeszultDisz)
            {
                Console.WriteLine($"5. feladat: Volt olyan nap, amikor egyetlen dísz sem készült.");
            }
            else
            {
                Console.WriteLine($"5. feladat: Nem volt olyan nap, amikor egyetlen dísz sem készült.");
            }
            
            //6. feladat
            Console.WriteLine("6. feladat:");
            int nap = 0;
            do
            {
                Console.WriteLine("Adja meg a keresett napot [1...40]: ");
                nap = int.Parse(Console.ReadLine());
            } while (nap < 1 || nap > 40);
            int harangok = 0;
            int angyalok = 0;
            int fenyofak = 0;
            for (int i = 0; i < nap; i++)
            {
                harangok += diszek[i].HarangKesz + diszek[i].HarangEladott;
                angyalok += diszek[i].AngyalkaKesz + diszek[i].AngyalkaEladott;
                fenyofak += diszek[i].FenyofaKesz + diszek[i].FenyofaEladott;
            }
            Console.WriteLine($"\tA(z) {nap}. nap végén {harangok} harang, {angyalok} angyal, és {fenyofak} fenyőfa maradt készleten.");

            //7. feladat
            Console.Write("7. feladat: a legtöbbet eladott dísz: ");
            Dictionary<string, int> eladottak = new Dictionary<string, int>();
            eladottak.Add("Harang", 0);
            eladottak.Add("Angyalka", 0);
            eladottak.Add("Fenyőfa", 0);
            foreach (NapiMunka dísz in diszek)
            {
                eladottak["Harang"] -= dísz.HarangEladott;
                eladottak["Angyalka"] -= dísz.AngyalkaEladott;
                eladottak["Fenyőfa"] -= dísz.FenyofaEladott;
            }
            int max = eladottak.Values.Max();
            Console.WriteLine($"{max} darab");
            foreach (var item in eladottak)
            {
                if (item.Value == max)
                {
                    Console.WriteLine($"\t{item.Key}");
                }
            }
            Console.WriteLine();

            //8. feladat
            StreamWriter sw = new StreamWriter("bevétel.txt");
            int legalabb10000 = 0;
            foreach (NapiMunka dísz in diszek)
            {
                if (dísz.NapiBevetel() >= 10000)
            }


            Console.ReadKey();
        }
    }
}
