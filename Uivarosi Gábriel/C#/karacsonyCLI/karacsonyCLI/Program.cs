using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace karacsonyCLI
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            List<NapiMunka> Beolvasot_lista = new List<NapiMunka>();
         foreach (string sor in File.ReadAllLines("diszek.txt")) 
            {
                Beolvasot_lista.Add(new NapiMunka(sor));
            }


            Console.WriteLine($"4.feladat: Összesen {NapiMunka.KeszultDb} darab dísz készűlt");
          
            bool NemkeszultDisz = false;

            foreach (NapiMunka dísz in Beolvasot_lista) 
            {
                if (dísz.HarangKesz == 0 && dísz.AngyalkaKesz == 0 && dísz.FenyofaKesz == 0) {
                
                    NemkeszultDisz = true;
                    break;
                }
            }
            if (NemkeszultDisz)
            {
                Console.WriteLine("Volt olyan nap, amin Dísz nem készűlt ell");

            } else { Console.WriteLine("Dolgozott"); }
            bool Rosz_bekért_nap = true;
            int bekért_nap = 0;
            do
            {
                Console.WriteLine("Kérem agyon egy napot 1-40!");
                 bekért_nap = Convert.ToInt32(Console.ReadLine()) ;
                if (bekért_nap < 41 && bekért_nap > 0) Rosz_bekért_nap = false;
            } while (Rosz_bekért_nap);
            int harangok = 0;
            int angyalok = 0;
            int feyofak = 0;
            for (int i = 0; i < bekért_nap; i++)
            {
                harangok += Beolvasot_lista[i].HarangKesz + Beolvasot_lista[i].HarangEladott;
                angyalok += Beolvasot_lista[i].AngyalkaKesz + Beolvasot_lista[i].AngyalkaEladott;
                feyofak += Beolvasot_lista[i].FenyofaKesz + Beolvasot_lista[i].FenyofaEladott;
            }
            Console.WriteLine($"\tA(z) {bekért_nap}. nap végén {harangok} harang, {angyalok} angyal, {feyofak} fenyőfa maradt készleten");

            // 7. feladat
            Console.Write("7. feladat: a legtöbbet eladott dísz:");
            Dictionary<string, int> eladottak = new Dictionary<string, int>();
            eladottak.Add("Harang", 0);
            eladottak.Add("Angyalka", 0);
            eladottak.Add("Fenyűfa", 0);
            
        
           foreach (NapiMunka dísz in Beolvasot_lista)
            {
                eladottak["Harang"] -= dísz.HarangEladott;
                eladottak["Angyalka"] -= dísz.AngyalkaEladott;
                eladottak["Fenyűfa"] -= dísz.FenyofaEladott;
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

            // 8. feladat
            StreamWriter sw = new StreamWriter("Bevétel.txt");
            int legalabb10000 = 0;
            foreach (NapiMunka dísz in Beolvasot_lista )
            {
                if (dísz.NapiBevetel() >= 10000)
                {
                    sw.WriteLine($"{dísz.Nap} - {dísz.NapiBevetel()}");
                    legalabb10000++;
                }
            }
            sw.WriteLine($"{legalabb10000} napon volt legalább 10000 Ft a bevétel. \n");
            sw.Close();
            Console.ReadKey();
        } 
    }
}


