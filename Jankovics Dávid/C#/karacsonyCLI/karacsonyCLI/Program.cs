using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.InteropServices;
using System.Net.Http.Headers;

namespace karacsonyCLI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<NapiMunka> lista = new List<NapiMunka>();

            //3.feladat
            foreach (var item in File.ReadAllLines("diszek.txt")) 
            {
                lista.Add(new NapiMunka(item));
            }

            //4.feladat
            
            Console.WriteLine($"4.feladat: Összesen {NapiMunka.KeszultDb} dísz készült.");

            bool nem_keszult_disz = false;

            //5.feladat
            foreach(var item in lista) 
            {
                if (item.HarangKesz == 0 && item.AngyalkaKesz == 0 && item.FenyofaKesz == 0)
                {
                    nem_keszult_disz = true;
                    break;
                }
            }

            if (nem_keszult_disz)
            {
                Console.WriteLine("5.feladat: Volt olyan nap, amikor egyetlen dísz sem készült.");
            }

            else
            {
                Console.WriteLine("5.feladat: Nem volt olyan nap, amikor egyetlen dísz sem készült.");
            }

            //6.feladat
            Console.WriteLine("6.feladat:");

           
            int napSzama;

            do
            {
                Console.Write("Adja meg a keresett napot[1 ... 40]: ");
                napSzama = Convert.ToInt32(Console.ReadLine());

            }
            while (1 > napSzama || napSzama > 40);

            int harangok = 0;
            int angyalok = 0;
            int fenyofak = 0;

            for(int i = 0; i < napSzama; i++)
            {
                harangok += lista[i].HarangKesz + lista[i].HarangEladott;
                angyalok += lista[i].AngyalkaKesz + lista[i].AngyalkaEladott;
                fenyofak += lista[i].FenyofaKesz + lista[i].FenyofaEladott;
            }

            

            Console.WriteLine($"\t A {napSzama} nap végén {harangok} harang, {angyalok} angyal és {fenyofak} fenyőfa maradt készleten.");

            //7.feladat
            Console.Write("7.feladat: a legtöbbet eladott dísz: ");
            Dictionary<string, int> eladottak = new Dictionary<string, int>();
            eladottak.Add("Harang", 0);
            eladottak.Add("Angyalka", 0);
            eladottak.Add("Fenyőfa", 0);
            foreach(var disz in lista)
            {
                eladottak["Harang"] -= disz.HarangEladott;
                eladottak["Angyalka"] -= disz.AngyalkaEladott;
                eladottak["Fenyőfa"] -= disz.FenyofaEladott;
            }
            int max = eladottak.Values.Max();
            Console.WriteLine($"{max} darab");

            foreach(var item in eladottak) 
            {
                if (item.Value == max)
                {
                    Console.WriteLine($"\t{item.Key}");
                }
            }
            Console.WriteLine();

            //8.feladat
            StreamWriter sw = new StreamWriter("bevétel.txt");
            int legalabb10000 = 0;
            foreach (var disz in lista)
            {
                if (disz.NapiBevetel() >= 10000)
                {
                    sw.WriteLine($"{disz.Nap} - {disz.NapiBevetel()}");
                    legalabb10000++;
                }
            }
            sw.WriteLine($"{legalabb10000} napon volt legalább 10000 Ft a bevétel.\n");
            sw.Close();

            Console.ReadKey();
        }
    }
}
